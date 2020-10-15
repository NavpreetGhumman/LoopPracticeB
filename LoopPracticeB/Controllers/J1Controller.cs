using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Web.Http;
using WebGrease;

namespace LoopPracticeB.Controllers
{
    public class J1Controller : ApiController
    {


        /// <summary>
        /// Pick number from 1 to 4 to choose your meal then calculate and display the total calories
        /// </summary>
        /// <param name="burger">input to select the burger</param>
        /// <param name="drink">input to select the drink</param>
        /// <param name="side">input to select the side</param>
        /// <param name="dessert">input to select the dessert</param>
        /// <example>
        /// api/J1/Menu/4/4/4/4    -->   "Your total calorie count is 0"
        /// </example>
        /// <example>
        /// api/J1/Menu/1/2/3/4    -->   "Your total calorie count is 691"
        /// </example>
        /// <returns>Return the total calories of the meal</returns>


        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string Menu(int burger, int drink, int side, int dessert)
        {
           //Array of calories of different food option
            int[] chooseBurger =  { 461, 431, 420, 0 };
            int[] chooseDrink =  { 130, 160, 118, 0 };
            int[] chooseSide =  { 100, 57, 70, 0 } ;
            int[] chooseDessert =  { 167, 266, 75, 0 };

            //condition to check whether they enter valid number or not
            if (burger <= 4 && drink <= 4 && side <= 4 && dessert <= 4)
            {
                int calories = chooseBurger[burger - 1] + chooseDrink[drink - 1] + chooseSide[side - 1] + chooseDessert[dessert - 1];
                return "Your total calorie count is " + calories;
            }
            else
            {
                return "0";
            }
        }
    }
}
