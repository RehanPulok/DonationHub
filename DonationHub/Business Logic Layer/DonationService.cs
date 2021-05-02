using DonationHub.Data_Access_Layer;
using DonationHub.Data_Access_Layer.Entities;
using DonationHub.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationHub.Business_Logic_Layer
{
    class DonationService
    {
        MoneyDonationDataAccess moneyDonationDataAccess;
        DonationDataAccess donationDataAccess;

        public DonationService()
        {
            this.moneyDonationDataAccess = new MoneyDonationDataAccess();
            this.donationDataAccess = new DonationDataAccess();
        }

        public int DonateByBkash(long phoneNumber, int amount, int pin)
        {
            MoneyDonation moneyDonation = new MoneyDonation()
            {
                MobileNumber= phoneNumber,
                BkashAmount= amount,
                BkashPin= pin
            };
            return moneyDonationDataAccess.BkashDonation(moneyDonation);
        }
        public int DonateByCard(long cardNumber, int amount, int pin)
        {
            MoneyDonation moneyDonation = new MoneyDonation()
            {
                CardNumber = cardNumber,
                CardAmount = amount,
                CardPin = pin
            };
            return moneyDonationDataAccess.CardDonation(moneyDonation);
        }
        public int CheckAmountCard(int donorID, int organisationID)
        {
            MoneyDonation donation = new MoneyDonation()
            {
                //DonorID = donorID,
                //OrganisationID = organisationID
                
            };
            return donationDataAccess.CheckAmountCard(donation);
        }
        public int CheckAmountBkash(int donorID, int organisationID)
        {
            MoneyDonation donation = new MoneyDonation()
            {
                //DonorID = donorID,
                //OrganisationID = organisationID

            };
            return donationDataAccess.CheckAmountCard(donation);
        }
        public int MakeDonation(int donorID, int organisationID, int amount, string food)
        {
            Donation donation = new Donation()
            {
                DonorID = donorID,
                OrganisationID = organisationID,
                Amount = amount,
                Food = food

            };
            return donationDataAccess.MakeDonation(donation);
        }
    }
}
