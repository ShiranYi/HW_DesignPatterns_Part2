using HW_DesignPatterns_Part2;
using HW_DesignPatterns_Part2.Mediator;
using HW_DesignPatterns_Part2.Proxy;

#region Mediator

IFacebookGroup facebookGroup = new FacebookGroup();
Member dina = new Member(facebookGroup, "Dina");
Member shula = new Member(facebookGroup, "Shula");
Member yaron = new Member(facebookGroup, "Yaron");

facebookGroup.Register(dina);
facebookGroup.Register(shula);
facebookGroup.Register(yaron);

dina.Publish("Hey everyone!!");

#endregion

Console.WriteLine("\n====================================\n");

#region Proxy

var myMachine = new InteriorOffice();
myMachine.UpdateVersion();
myMachine.ShutDown();
Console.WriteLine();

var machine = new ServiceMachine(myMachine);
machine.GetInfo();
machine.ChangeAddress();
machine.PassportRenewal();



#endregion

