namespace Model;
public class Child:Father
{
    public Child(int Id, string Name): base(Id, Name)
    {
    }

    public override String ToString(){
        return $"Bienvenido {base.ToString()}";
    }

    public String ToString(String key)
    {
        return $"{key} {base.ToString()}";
    }
}