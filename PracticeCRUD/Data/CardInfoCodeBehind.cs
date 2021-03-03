using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCard_Stripe.Data;
using PracticeCRUD.Data;
using Stripe;
using PracticeCRUD.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using PracticeCRUD.DbData;
namespace PracticeCRUD.Data
{
    public class CardInfoCodeBehind : LayoutComponentBase
    {

      

        //public CheckOutModel checkOut = new CheckOutModel();
        //public DbData.Customer CurrentCustomer = new DbData.Customer();
        //public OrderHistory OrderHistory = new OrderHistory();
        //public long amountToCharge = 0;
        //public string[] paymentDetails = new string[] { };


      





        //public void MyCall()
        //{

        //    StripeConfiguration.ApiKey = "sk_test_JeiTNW3ZLfMPN8jnlkk5U5Qa";

        //    var optionsCustomer = new CustomerCreateOptions
        //    {
        //        Email = checkOut.EmailAddress,
        //        Phone = checkOut.PhoneNumber


        //    };
        //    var serviceCustomer = new CustomerService();
        //    serviceCustomer.Create(optionsCustomer);
        //    CardCreateNestedOptions token = new CardCreateNestedOptions()
        //    {
        //        Number = checkOut.CreditCard,
        //        ExpMonth = int.Parse(checkOut.ExpiryMonth),
        //        ExpYear = int.Parse(checkOut.ExpiryYear),
        //        Cvc = checkOut.CVC,
        //        Name = checkOut.Name,
        //        AddressLine1 = checkOut.AddressLine1,
        //        AddressLine2 = checkOut.AddressLine2,
        //        AddressCity = checkOut.City,
        //        AddressZip = checkOut.Zipcode
                
                
                

        //    };

        //    var optionsCharge = new ChargeCreateOptions
        //    {

        //        Amount = amountToCharge,
        //        Currency = "usd",
        //        Source = token,
        //        ReceiptEmail = checkOut.EmailAddress,





        //    };

        //    var serviceCharge = new ChargeService();
        //    serviceCharge.Create(optionsCharge);

        //    var optionsToken = new TokenCreateOptions
        //    {
        //        Card = new TokenCardOptions
        //        {
        //            Number = checkOut.CreditCard,
        //            ExpMonth = int.Parse(checkOut.ExpiryMonth),
        //            ExpYear = int.Parse(checkOut.ExpiryYear),
        //            Cvc = checkOut.CVC,
        //        },
        //    };
        //    var serviceToken = new TokenService();
        //    serviceToken.Create(optionsToken);
        //    checkOut.CreditCard = null;
        //    checkOut.CVC = null;
        //    checkOut.EmailAddress = null;
        //    checkOut.Name = null;
        //    checkOut.ExpiryMonth = null;
        //    checkOut.ExpiryYear = null;
        //    checkOut = new CheckOutModel();
            

        //}

            

    }




}



