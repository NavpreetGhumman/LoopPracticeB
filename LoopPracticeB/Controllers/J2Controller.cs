using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoopPracticeB.Controllers
{
    public class J2Controller : ApiController
    {

        /// <summary>
        /// Use two different dice m and n to find number of ways to get sum 10
        /// </summary>
        /// <param name="m">Input for first die</param>
        /// <param name="n">Input for second die</param>
        /// <example>
        /// api/J2/DiceGame/6/8
        /// </example>
        /// <example>
        /// api/J2/DiceGame/12/4
        /// </example>
        /// <example>
        /// api/J2/DiceGame/3/3
        /// </example>
        /// <example>
        /// api/J2/DiceGame/5/5
        /// </example>
        /// <returns>Possible number of ways to get sum 10</returns>
        
        
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        public string DiceGame(int m, int n)
        {
            int c;
            c = 0;
            for(int i = 1; i <= m; i++)
            {
                if (10 - i <= n && 10 - i >= 0)
                {
                    c = c + 1;
                }
            }
            if (c == 1)
            {
                return "there is " + c + " ways to get the sum 10";
            }
            else
            {
                return "there is" + c + " ways to get the sum 10";
            }
        }
    }
}
