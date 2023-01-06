using System;
using System.Collections.Generic;
using System.Xml;

namespace ClassWork
{
    // 
    internal class XmlSerializerForOrders
    {
        public string FileName => "Order.xml";
        public List<Product> Order { get; set; }

        public XmlSerializerForOrders(bool isTest = false)
        {
            if (isTest)
            {
                Test();
            }
        }

        private void Test()
        {
            Order = new List<Product>{
                new Product(){Name = "Sugar", DeliveryDate = new DateTime(2022,11,25), Price = 50 },
                new Product(){Name = "Salt", DeliveryDate = new DateTime(2022,11,25), Price = 40 },
                new Product(){Name = "Bread", DeliveryDate = new DateTime(2022,11,25), Price = 100 }
            };

            Write();
            var node = Read();
            Print(node);
        }

        public void Write()
        {
            XmlDocument doc = new XmlDocument();
            var mainNode = doc.CreateNode(XmlNodeType.Element, "Order", "");
            foreach (var item in Order)
            {
                var node = doc.CreateNode(XmlNodeType.Element, "Product", "");

                var element = doc.CreateElement("Name");
                element.AppendChild(doc.CreateTextNode(item.Name));
                node.AppendChild(element);

                element = doc.CreateElement("DeliveryDate");
                element.AppendChild(doc.CreateTextNode(item.DeliveryDate.ToString()));
                node.AppendChild(element);

                element = doc.CreateElement("Price");
                element.AppendChild(doc.CreateTextNode(item.Price.ToString()));
                node.AppendChild(element);

                mainNode.AppendChild(node);
            }
            doc.AppendChild(mainNode);
            doc.Save(FileName);
        }

        public XmlNode Read()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FileName);
            return doc;
        }

        public void Print(XmlNode node)
        {
            if (node.NodeType == XmlNodeType.Text)
            {
                Console.Write($"{node.Value}\t");
                if(node.ParentNode.Name == "Price")
                {
                    Console.WriteLine();
                }
            }
            if (node.HasChildNodes)
            {
                foreach (XmlNode item in node.ChildNodes)
                {
                    Print(item);
                }
            }
        }
    }
}