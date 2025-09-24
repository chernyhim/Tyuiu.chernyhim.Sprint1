using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.chernyhim.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            string lw;
            string prelw;
            string[] words = value.Split(' ');
            lw = words[words.Length - 1];
            prelw = words[words.Length - 2];
            if(lw == prelw)
            {
                return true;

            }
            else
            {
                return false;
            }
          

        }
    }
}
