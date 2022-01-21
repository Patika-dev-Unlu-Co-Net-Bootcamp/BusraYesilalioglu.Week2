using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnluCo.Week1.HomeWork
{
    public class Cats /* Get:Okunabilir Set:Deðiþtirilebilir */
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Elle Id vermek yerine otomatikmen Id'sini veren komut
       public int Id { get; set; }
       public string Name { get; set; }
       public string Breed { get; set; }
       public int GenderId { get; set; }
       public double Age { get; set; }
       public string Color { get; set; }
       public DateTime DateOfBirth { get; set; }
    }
}
