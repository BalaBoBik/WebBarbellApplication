using System.Xml.Linq;

namespace WebBarbellApplication.Manager
{
    public class AppManager : IAppManager
    {
        private List<int> _pancakesWeight = new List<int>() {1, 3, 5, 10, 15, 20, 25, 30 };


        public async Task<List<int>> SimpleCalculateBarbell(int weight)
        {
            List<int> result = new List<int>();
            if (weight >= 23)
            {
                int barbellPancake = (weight - 23) / 2;
                
                result.Add(barbellPancake);
                result.Add(barbellPancake);
            }
            return result;
        }
        public async Task<List<int>> CalculateBarbell(int weight)
        { 
            List<int> result = new List<int>();
            var pancakesWeight = _pancakesWeight;
            pancakesWeight.Sort();

            weight -= 23;
           
            for(int i= pancakesWeight.Count-1; i>=0; i--) 
            {
                while(weight >= pancakesWeight[i]*2)
                {
                    weight -= pancakesWeight[i]*2;

                    result.Add((pancakesWeight[i]));
                    result.Add((pancakesWeight[i]));
                }

                if (weight == 0)
                    break;
            }

            return result;
        }
        public async Task<List<string>> BarbellOutput(List<int> pancakes)
        {
            List<string> result = new List<string>();
            result.Add("Штанга = 20 кг");
            result.Add("Затяжка = 1,5 кг");
            if (pancakes.Count != 0)
            {

                foreach (int pancake in pancakes)
                {
                    result.Add($"Блин = {pancake} кг");
                }
                result.Add($"Общий вес штанги = {pancakes.Sum()+23} кг");
            }
            else
            {
                result.Add("Минимальный вес штанги = 23 кг");
            }
            return result;
        }
    }
}
