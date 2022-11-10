using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace BinarySerializationDemo
{
    public class Binary
    {
        public void Serialize()
        {
            Demo demo = new Demo();
            FileStream file = new FileStream(@"D:\Lfp194\BinarySerializationDemo\Example.txt",FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(file, demo);
        }
        public void Deserialize()
        {
            FileStream fileStream = new FileStream(@"D:\Lfp194\BinarySerializationDemo\Example.txt", FileMode.Open);
            BinaryFormatter formatter=new BinaryFormatter();
            Demo desrialize=(Demo)formatter.Deserialize(fileStream);

            Console.WriteLine(desrialize.ApplicatioName+"  "+desrialize.ApplicationID);
        }
    }


    [Serializable]
    public class Demo
    {
        public string ApplicatioName { get; set; } = "Binary Serialize";
        public int ApplicationID { get; set; } = 100;

    }

}
