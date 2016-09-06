using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banzilla.Client.Responses
{
  public  class PlanResponse
    {
      public string IdPlan { get; set; }
      public bool IsActive { get; set; }
      public string Created { get; set; }
      public string PlanName { get; set; }
      public string Description { get; set; }
      public decimal Amount { get; set; }
      public int Frequency { get; set; }
      public int RepeatEvery { get; set; }
      public int PlanDuration { get; set; }
      public int Attemps { get; set; }

    }
}
