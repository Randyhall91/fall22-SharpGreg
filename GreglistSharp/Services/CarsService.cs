namespace GreglistSharp.Services;

public class CarsService
{
  // REPOSITORY PATTERN
  // will be used to control communication with the DB

  private readonly CarsRepository _carsRepo;

  public CarsService(CarsRepository carsRepo)
  {
    _carsRepo = carsRepo;
  }

  public List<Car> GetCars()
  {
    return _carsRepo.GetCars();
  }

  public Car CreateCar(Car carData)
  {
    return _carsRepo.CreateCar(carData);
  }

  internal Car UpdateCar(Car carData, int id)
  {
    return _carsRepo.UpdateCar(carData, id);
  }

  internal Car GetCarById(int id)
  {
    return _carsRepo.GetCarById(id);
  }

  internal Car DeleteCar(int id)
  {
    return _carsRepo.DeleteCar(id);
  }
}