using FactLibrary;

namespace FactorialController.Controllers;

public class FactorialController : Controller
{
      private readonly FactorialCalculator factorialCalculator;
    public FactorialController(){
        factorialCalculator = new FactorialCalculator();
    }

    public IndexActionResult Index(){
        int number = 5;
        long factorialResult;

        try{
            factorialResult = factorialCalculator.Calculate(number);
        }
        catch (Exception ex){
            return View("Error", ex.Message);
        }
        return View(factorialResult);
    }

}