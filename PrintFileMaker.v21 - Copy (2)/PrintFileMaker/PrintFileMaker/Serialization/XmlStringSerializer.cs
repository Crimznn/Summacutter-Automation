using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Rutland.PrintFileMaker.Serialization
{
    /// <summary>
    /// Enum to specify how to handle duplicate file names
    /// </summary>
    public enum IfFileExists { OverwriteFile, AppendSuffix }

    public class XmlStringSerializer
    {

        /// <summary>
        /// Specifies how to handle duplicate file names (defaults to Overwrite file)
        /// </summary>
        public IfFileExists HandleDuplicateFile { get; set; }

        /// <summary>
        /// Allows objects to be serialized without namespace attributes.
        /// </summary>
        public bool OmitNamespaces { get; set; }

        private XmlSerializerNamespaces NameSpaces;

        public XmlStringSerializer()
        {
            //overwrite existing files of same name is default
            HandleDuplicateFile = IfFileExists.OverwriteFile;
            OmitNamespaces = true;
            NameSpaces = new XmlSerializerNamespaces();
            NameSpaces.Add("", "");
        }

        public void ResetNamespaces()
        {
            NameSpaces = new XmlSerializerNamespaces();
        }

        public void AddNamespace(string pfx, string ns)
        {
            NameSpaces.Add(pfx, ns);
        }

        /// <summary>
        /// Serializes a serializable object to an XML string
        /// </summary>
        /// <param name="Obj">Object to be serialized</param>
        /// <param name="ObjType">Type of object</param>
        /// <returns>Serialized xml as a string</returns>
        public string ToXml(object Obj, System.Type ObjType)
        {
            string xml = String.Empty;
            XmlSerializer serializer = new XmlSerializer(ObjType);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (XmlTextWriter xmlWriter = new XmlTextWriter(memoryStream, Encoding.UTF8))
                {
                    if (OmitNamespaces)
                    {
                        serializer.Serialize(xmlWriter, Obj, NameSpaces);
                    }
                    else
                    {
                        serializer.Serialize(xmlWriter, Obj);
                    }

                    xml = Encoding.UTF8.GetString(memoryStream.GetBuffer());
                    xml = xml.Substring(xml.IndexOf(Convert.ToChar(60)));
                    xml = xml.Substring(0, (xml.LastIndexOf(Convert.ToChar(62)) + 1));
                }
            }
            return xml;
        }


        /// <summary>
        /// Serializes a serializable object to an XML string and writes xml to 
        /// specified file path.
        /// </summary>
        /// <param name="Obj">Object to be serialized</param>
        /// <param name="ObjType">Type of object</param>
        /// <param name="destinationFilePath">filepath -- (c:\fullPath\file.name)</param>
        /// <returns>Serialized xml as a string</returns>
        public string ToXml(object Obj, System.Type ObjType, string destinationFilePath)
        {
            ToXmlFile(Obj, ObjType, destinationFilePath);
            return ToXml(Obj, ObjType);
        }


        /// <summary>
        /// Serializes a serializable object to an XML file 
        /// </summary>
        /// <param name="Obj">Object to be serialized</param>
        /// <param name="ObjType">Type of object</param>
        /// <param name="destinationFilePath">filepath -- (c:\fullPath\file.name)</param>
        public void ToXmlFile(object Obj, System.Type ObjType, string destinationFilePath)
        {
            XmlSerializer serializer = new XmlSerializer(ObjType);

            using (TextWriter file = new StreamWriter(CheckForDuplicateFile(destinationFilePath)))
            {
                if (OmitNamespaces)
                {
                    serializer.Serialize(file, Obj, NameSpaces);
                }
                else
                {
                    serializer.Serialize(file, Obj);
                }
            }

        }

        /// <summary>
        /// Writes an XML string to a specified XML file path
        /// </summary>
        /// <param name="Xml">XML String</param>
        /// <param name="destinationFilePath">filepath -- (c:\fullPath\file.name)</param>
        public void StringToXmlFile(string Xml, string destinationFilePath)
        {
            using (TextWriter file = new StreamWriter(CheckForDuplicateFile(destinationFilePath)))
            {
                file.Write(Xml);
            }
        }


        /// <summary>
        /// Deserializes an XML File to an object. 
        /// </summary>
        /// <param name="objType">Object type</param>
        /// <param name="sourceFilePath">filepath -- (c:\fullPath\file.name)</param>
        /// <returns>Deserialized XML as Object</returns>
        public object ToObject(System.Type objType, string sourceFilePath)
        {
            XmlSerializer serializer = new XmlSerializer(objType);

            using (FileStream fs = new FileStream(sourceFilePath, FileMode.Open))
            {
                using (XmlReader reader = new XmlTextReader(fs))
                {
                    return serializer.Deserialize(reader);
                }
            }
        }

        /// <summary>
        /// Deserializes an XML String to an object
        /// </summary>
        /// <param name="objType">Object Type</param>
        /// <param name="xmlString">XML string</param>
        /// <returns>Deserialized XML as Object</returns>
        public object ToObjectFromString(System.Type objType, string xmlString)
        {
            XmlSerializer serializer = new XmlSerializer(objType);

            using (StringReader stringReader = new StringReader(xmlString))
            {
                using (XmlTextReader xmlReader = new XmlTextReader(stringReader))
                {
                    return serializer.Deserialize(xmlReader);
                }
            }
        }

        /// <summary>
        /// Moves file from source directory to destination directory
        /// </summary>
        /// <param name="sourceFile">filepath -- (c:\fullPath\file.name)</param>
        /// <param name="destinationFile">filepath -- (c:\fullPath\file.name)</param>
        public void MoveFile(string sourceFile, string destinationFile)
        {
            File.Move(sourceFile, CheckForDuplicateFile(destinationFile));
        }

        /// <summary>
        /// Checks folder for duplcate file name. If there is a duplicate file name, 
        /// it will be handled based on the enum value of the HandleDuplicateFile
        /// property.
        /// </summary>
        /// <param name="fileName">filepath -- (c:\fullPath\file.name)</param>
        /// <returns></returns>
        private string CheckForDuplicateFile(string fileName)
        {
            //if the File name already exists in this path check the "ExistingFile" property           
            if (File.Exists(fileName))
            {
                switch (HandleDuplicateFile)
                {
                    case IfFileExists.OverwriteFile:
                        File.Delete(fileName);
                        break;
                    case IfFileExists.AppendSuffix:
                        //fileName = FileNameAppender.GetNext(fileName);
                        break;
                    default:
                        break;
                }
            }
            return fileName;
        }
    }
}
