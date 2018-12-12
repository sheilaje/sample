using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace Dice.Models
{
  public class User
  {

    private string _name;
    private int _id;
    private int _distance;
    private int _priceRange;
    private List<User> _favorites;

    public User(string name, int distance, int priceRange,int id = 0)
    {
      _name = name;
      _id = id;
      _distance = distance;
      _priceRange = priceRange;
      _favorites = new List<User>{};
    }
    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    public int GetPriceRange()
    {
      return _priceRange;
    }

    public int GetDistance()
    {
      return _distance;
    }


  }
}
