using Data;
using System.Collections.Generic;

public interface ICityRepository
{
    bool Create(City city);

    List <City> GetAll();

    List<City> GetAllByDistrictId(int districtId);
}