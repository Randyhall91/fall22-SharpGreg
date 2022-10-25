namespace GreglistSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarsController : ControllerBase
{
  private readonly CarsService _carsService;

  public CarsController(CarsService carsService)
  {
    _carsService = carsService;
  }


  [HttpGet]
  public ActionResult<List<Car>> Get()
  {
    try
    {
      List<Car> cars = _carsService.GetCars();
      return Ok(cars);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  [HttpGet("{id}")]
  public ActionResult<Car> GetCarById(int id)
  {
    try
    {
      Car car = _carsService.GetCarById(id);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }


  [HttpPost]
  public ActionResult<Car> Create([FromBody] Car carData)
  {
    try
    {
      Car car = _carsService.CreateCar(carData);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  [HttpPut("{id}")]
  public ActionResult<Car> Update([FromBody] Car carData, int id)
  {
    try
    {
      Car car = _carsService.UpdateCar(carData, id);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{id}")]
  public ActionResult<Car> Delete(int id)
  {
    try
    {
      Car car = _carsService.DeleteCar(id);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}
