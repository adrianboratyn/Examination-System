using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
{
    /// <summary>
    /// Represents all results in the form of ranking  
    /// </summary>
    public class RankingModel
    {
        /// <summary>
        /// List of all results
        /// </summary>
        public List<ResultModel> ResultList { get; set; } = new List<ResultModel>();
        //sortowanie listy po testach, testy po wynikach itd
    }
}
