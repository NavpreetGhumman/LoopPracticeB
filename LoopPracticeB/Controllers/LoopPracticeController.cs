using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoopPracticeB.Controllers
{
    public class LoopPracticeController : ApiController
    {
        /// <summary>
        /// Count from start to end counted by step
        /// </summary>
        /// <param name="start"></param>
        /// <param name="limit"></param>
        /// <param name="step"></param>
        /// <returns>A string of numbers separated by ","</returns>
        [Route("api/LoopPractice/CounterList/{start}/{limit}/{step}")]
        [HttpGet]
        public IEnumerable<int> CounterList(int start, int limit, int step)
        {
           
            bool isIncreasing = (start < limit && step > 0);
            bool isDecreasing = (start > limit && step < 0);
            List<int> steps = new List<int>();
            if (!isIncreasing || !isDecreasing)
            {
                steps.Add(0);
            }
            else
            {
                for (int i = start; i <= limit; i += step)
                {
                    steps.Add(i);
                }
            }
            return steps;
        }


        [Route("api/LoopPractice/CounterString/{start}/{limit}/{step}")]
        [HttpGet]
        public string CounterString(int start, int limit, int step)
        {

            bool isIncreasing = (start <= limit && step > 0);
            bool isDecreasing = (start >= limit && step < 0);
            string message = "";
            if (!isIncreasing || !isDecreasing)
            {
                message = "0";
            }
            else
            {
                for (int i = start; i <= limit; i += step)
                {
                    message = message + i.ToString() + ",";
                }
            }
            return message;
        }

    }
}
