namespace webapi.Models
{
  public class MainMenuItem
  {
    public MainMenuItem(int id, string name, int priority)
    {
      Id = id;
      Name = name;
      Priority = priority;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Priority { get; set; }

    public static MainMenuItem[] DefaultList()
    {
      return new MainMenuItem[]
      {
        new MainMenuItem(1, "Клапаны", 1),
        new MainMenuItem(2, "Вентиляторы", 2),
        new MainMenuItem(3, "Заслонки", 3),
        new MainMenuItem(4, "Решетки", 4),
        new MainMenuItem(5, "Канальная группа", 5)
      };
    }
  }

}
