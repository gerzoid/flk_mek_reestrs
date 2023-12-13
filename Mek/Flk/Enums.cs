using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mek.Flk
{
    public enum TYPE_REESTR
    {
        C = 0,  //онко
        H = 1,  //омс
        L = 2,  //перс данные
        PL = 3, //МТР
        R = 4,  //МТР основная часть
        T = 5,  //Высокотехнологичная помощь
        V = 6,  //Флк
        X = 7,  //ДД
        Y = 8,  //Флк МТР
    }

    public enum TYPE_ELEMENT
    {
        Н,
        НМ,
        О,
        ОМ,
        У,
        УМ
    }

    public enum FORM_ELEMENT
    {
        S = 'S',
        T = 'T',
        D = 'D',
        N = 'N'
    }

}
