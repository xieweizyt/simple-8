using System;

namespace simple_8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region async/await 执行顺序
            {
                SimpleAsync.Show();
            }
            #endregion


            #region async/await 执行顺序
            {

            }
            #endregion

            Console.Read();
        }
    }
}
