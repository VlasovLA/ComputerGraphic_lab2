using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Vlasov_tomogram_visualizer
{
    class Bin
    {
        public static int X, Y, Z;
        public static short[] array;
        public Bin()
        {

        }

        public void readBIN(string path)
        {
            /*using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                int x, y, z;
                x = 44;
                y = 44;
                z = 40;
                writer.Write(x); 
                writer.Write(y); 
                writer.Write(z); 
                for (int i = 1; i <= x*y*z/4; i++)
                {
                    writer.Write(i*4);
                    writer.Write(x*y*z - i*4);
                    writer.Write(3254*i % x*y*z);
                    writer.Write(5003 / i);
                }
                //writer.Write(0);
            }*/

            if (File.Exists(path))
            {
                BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open));
                X = reader.ReadInt32();
                Y = reader.ReadInt32();
                Z = reader.ReadInt32();

                int arraySize = X * Y * Z;
                array = new short[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    array[i] = reader.ReadInt16();

                }
            }
        }
    }
}
