using Data;
using System.Collections.Generic;

public class CityRepository : ICityRepository
{
    EmployeeDbContext _db = new EmployeeDbContext();


    public bool Create(City city)
    {
        throw new System.NotImplementedException();
    }

    public List<City> GetAll()
    {
        throw new System.NotImplementedException();
    }

    public List<City> GetAllByDistrictId(int districtId)
    {
        throw new System.NotImplementedException();
    }
}