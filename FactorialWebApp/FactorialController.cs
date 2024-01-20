using FactLibrary;

namespace FactorialController.Controllers;

public class FactorialController : Controller
{
      private readonly FactorialService factorialService;
    public FactorialController(){
        factorialService = new FactorialService();
    }

    public IndexActionResult Index(){
        int number = 5;
        long factorialResult;

        try{
            factorialResult = factorialService.Calculate(number);
        }
        catch (Exception ex){
            return View("Error", ex.Message);
        }
        return View(factorialResult);
    }

}