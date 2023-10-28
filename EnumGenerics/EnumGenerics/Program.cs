//using EnumGenerics;
//using GenericsHomeWork;

//intList list = new();

////list.Add(1);
////list.Add(2);
////list.Add(3);
////list.GetAll();

//StringList list2 = new();

////list2.Add("Hello");
////list2.Add("Bye Bye");

////list2.GetAll();

//PersonList person = new();

////person.Add( new Person { Id=1,Name="Metanet",Surname="Abbasova"});
////person.Add(new Person { Id = 2, Name = "Cavid", Surname="Bashirov" });
////person.Add(new Person { Id = 3, Name = "Naida", Surname="Basharatova" });

////person.GetAll();

//DataList<int> datas = new();

////datas.Add(1);
////datas.Add(2);

////datas.GetAll();


//DataList<string> str = new();

////str.Add("men");
////str.Add("Hello");

////str.GetAll();

////DataList<Person> students = new();

////students.Add(new Person { Id = 1, Name = "Metanet", Surname = "Abbasova" });
////students.Add(new Person { Id = 2, Name = "Cavid", Surname = "Bashirov" });

////var res = students.GetAll();

////foreach (var item in res)
////{
////    Console.WriteLine(item.Name + "" + item.Surname);
////}


////Repository<Person> repository = new Repository<Person>();
////Repository<int> repository2 = new Repository<int>();

////Repository<Person,BaseEntity> repository1 = new Repository<Person,BaseEntity>();

using EnumGenerics;
using System.Diagnostics;

//DataList<string> words = new DataList<string>();

//words.Add("bye");
//words.Add("Hello");
//words.Add("Good");

//var resp = words.GetAll();

//foreach (var item in resp)
//{
//    Console.WriteLine(item);
//}

//Repository<Person>people=new Repository<Person>();

//people.Add(new Person { Id=1,Name="Metanet",Surname="Abbasova"});
//people.Add(new Person { Id = 2, Name = "Cavid", Surname = "Bashirov" });


int paymentType = 1;

static void CheckPaymentType( int type) 
{
    switch (type)
    {
        case (int)PaymentType.Card:
            break;
        default:
            break;
    }
    //if (type ==PaymentType.Card.ToString())
    //{
    //    Console.WriteLine("Withcard");
    //}else if (type==PaymentType.Cash.ToString())
    //{
    //    Console.WriteLine("WithCash");
    //}
    //else
    //{
    //    Console.WriteLine("no");
    //}

}
CheckPaymentType(paymentType);