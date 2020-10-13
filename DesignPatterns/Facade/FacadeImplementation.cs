using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
  public  class FacadeImplementation
    {
        private IShape BMW;
        private IShape HoundaBike;
        public FacadeImplementation()
        {
            BMW = new Car();
            HoundaBike = new Bike();
        }
        public void DrawCar()
        {
            BMW.Draw();
        }
        public void DrawBike()
        {
            HoundaBike.Draw();
        }
    }
}
