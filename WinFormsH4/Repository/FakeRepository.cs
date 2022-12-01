using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogBook.Models;

namespace LogBook.Repository;

public static class FakeRepository
{
    public static List<Student> students = new()
    {
        new(1,null,"Vasif","Babazade","Asif",new DateTime(2022,12,1),ParticipationStatus.Unknown,null,null,null,null),
        new(2,null,"Royal","Beledli","Qudret",new DateTime(2022,12,1),ParticipationStatus.Unknown,null,null,null,null),
        new(3,null,"Huseyn","Hemidov","Reshadet",new DateTime(2022,12,1),ParticipationStatus.Unknown,null,null,null,null),
        new(4,null,"Mirtalib","Huseynzade","Ziyevich",new DateTime(2022,12,1),ParticipationStatus.Unknown,null,null,null,null),
        new(5,null,"Isa","Memmedli","Huseyn",new DateTime(2022,12,1),ParticipationStatus.Unknown,null,null,null,null),
        new(6,null,"Emin","Novruz","Zaur",new DateTime(2022,12,1),ParticipationStatus.Unknown,null,null,null,null),
    };
}
