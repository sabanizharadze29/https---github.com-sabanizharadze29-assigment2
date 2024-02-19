using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment2.Models;

namespace assignment2.Interfaces
{
    // 
    // შექმენით ცალკე კლასი, დაარქვით მას PersonService და
    // შექმენით ცალკე მეთოდი, სადაც შევინახავთ ახალ Person -ს და მასტან ასოცირებულ ყველაფერს (address,Phone,numbers,emails,events და ა.შ) ბაზაში.
    // მეთოდი რომლითაც წამოვიღებთ ყველაფერს კონკრეტული აიდით.
    // მეთოდი რომლითაც წამოღებულ პერსონას შეუცვლით ადდრესსს
    // და მეთოდი რომლითაც წაშლით პიროვნებასთან ასოცირებულ მხოლოდ ტელეფონს
    // დაწერეთ მეთოდი, რომლითაც წამოიღებთ ყველა ადამიანს რომელიც ცხოვრობს კონკრეტულ ადრესზე (ქუჩის სახელი)
    // დაწერეთ მეთოდი რომლითაც წამოიღებთ ხალხს მისი მეილით.
    // დასერჩავთ ხალხს, მისი სახელით.
    // და წამოიღებთ მხოლოდ იმ ხალხს რომლებიც 18 წელზე მეტია.
    public interface IPersonRepository : IRepository<Person>
    {


        void ChangeAddress(int personId, Address newAddress);
        void DeletePhoneNumbers(int personId);

        IEnumerable<Person> GetPersonsByAddress(string address);
        Person GetPersonByEmail(string email);
        IEnumerable<Person> SearchPersonsByName(string name);
        IEnumerable<Person> GetAdults();

    }
}