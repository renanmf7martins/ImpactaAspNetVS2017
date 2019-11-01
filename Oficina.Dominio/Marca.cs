namespace Oficina.Dominio
{
    public class Marca
    {
        public int Id { get; set; }

        public string Nome { get; set; }


        //public static Marca operator +(Marca marca1, Marca marca2)
        //{
        //    return new Marca
        //    {
        //        Id = marca1.Id + marca2.Id,
        //        Nome = marca1.Nome + marca2.Nome
        //    };
        //}

        //public static bool operator ==(Marca marca1, Marca marca2)
        //{
        //    return (marca1.Id == marca2.Id);
        //}

        //public static bool operator !=(Marca marca1, Marca marca2)
        //{
        //    return (marca1.Id != marca2.Id);
        //}

        //public static bool operator >=(Marca marca1, Marca marca2)
        //{
        //    return (marca1.Id >= marca2.Id);
        //}

        //public static bool operator <=(Marca marca1, Marca marca2)
        //{
        //    return (marca1.Id >= marca2.Id);
        //}

        //public static bool operator >(Marca marca1, Marca marca2)
        //{
        //    return (marca1.Id >= marca2.Id);
        //}

        //public static bool operator <(Marca marca1, Marca marca2)
        //{
        //    return (marca1.Id >= marca2.Id);
        //}
    }
}