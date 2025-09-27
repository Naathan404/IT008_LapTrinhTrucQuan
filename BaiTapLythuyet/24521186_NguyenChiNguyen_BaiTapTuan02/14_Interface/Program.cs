using System;

namespace Interface
{
    interface IStorable
    {
        void Read();
        void Write();
    }
    public class Document : IStorable
    {
        public void Read()
        {
            //....
        }
        public void Write()
        {
            //....
        }
    }

}