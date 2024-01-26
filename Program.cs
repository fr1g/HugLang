namespace HugLang{
  class Program{
    public void Main(string[] args)
    {
      HugLang instance = new(args[0]); // the very first argument should be the object that you will hugg
    }
  }

  class HugLang(string name){
    public string Name { get; set; }
    public string Hug()
    {
      if(this.Name == "myself") return "X";
      else return $"({this.Name})"
    }
  }
}
