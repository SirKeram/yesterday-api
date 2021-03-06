using System;

namespace YesterdayApi.Core.Users.Web
{
  public class UserResponse
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public string Login { get; set; }

    public DateTime BirthDate { get; set; }
  }
}