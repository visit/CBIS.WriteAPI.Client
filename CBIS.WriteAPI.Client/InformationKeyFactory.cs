using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBIS.WriteAPI.Client.Generated;

namespace CBIS.WriteAPI.Client
{
    public class InformationKeyFactory
    {
        private readonly CultureInfo _culture;

        public InformationKeyFactory(CultureInfo culture)
        {
            _culture = culture;
        }

        public InformationKey Name()
        {
            return new InformationKey()
            {
                AttributeId = 99,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Introduction()
        {
            return new InformationKey()
            {
                AttributeId = 101,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Description()
        {
            return new InformationKey()
            {
                AttributeId = 102,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Direction()
        {
            return new InformationKey()
            {
                AttributeId = 103,
                Culture = _culture.ToString()
            };
        }

        public InformationKey OpeningHours()
        {
            return new InformationKey()
            {
                AttributeId = 104,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Entrence()
        {
            return new InformationKey()
            {
                AttributeId = 105,
                Culture = _culture.ToString()
            };
        }

        public InformationKey PhoneNumberString()
        {
            return new InformationKey()
            {
                AttributeId = 107,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey MobilePhoneString()
        {
            return new InformationKey()
            {
                AttributeId = 108,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Email()
        {
            return new InformationKey()
            {
                AttributeId = 109,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Website()
        {
            return new InformationKey()
            {
                AttributeId = 110,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Other()
        {
            return new InformationKey()
            {
                AttributeId = 112,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Latitude()
        {
            return new InformationKey()
            {
                AttributeId = 113,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Longitude()
        {
            return new InformationKey()
            {
                AttributeId = 114,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey StreetAddress1()
        {
            return new InformationKey()
            {
                AttributeId = 117,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey StreetAddress2()
        {
            return new InformationKey()
            {
                AttributeId = 118,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey StreetAddress3()
        {
            return new InformationKey()
            {
                AttributeId = 119,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey PostalCode()
        {
            return new InformationKey()
            {
                AttributeId = 120,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey CityAddress()
        {
            return new InformationKey()
            {
                AttributeId = 121,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey CountryAddress()
        {
            return new InformationKey()
            {
                AttributeId = 122,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey EventType()
        {
            return new InformationKey()
            {
                AttributeId = 124,
                Culture = _culture.ToString()
            };
        }

        public InformationKey EventUrl()
        {
            return new InformationKey()
            {
                AttributeId = 125,
                Culture = _culture.ToString()
            };
        }

        public InformationKey BookUrl()
        {
            return new InformationKey()
            {
                AttributeId = 126,
                Culture = _culture.ToString()
            };
        }

        public InformationKey AgeLimit()
        {
            return new InformationKey()
            {
                AttributeId = 127,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumRooms()
        {
            return new InformationKey()
            {
                AttributeId = 130,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumFloors()
        {
            return new InformationKey()
            {
                AttributeId = 131,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumConferenceRooms()
        {
            return new InformationKey()
            {
                AttributeId = 132,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumBars()
        {
            return new InformationKey()
            {
                AttributeId = 133,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey YearBuilt()
        {
            return new InformationKey()
            {
                AttributeId = 134,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey LastRenovatedYear()
        {
            return new InformationKey()
            {
                AttributeId = 135,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey KeyPickup()
        {
            return new InformationKey()
            {
                AttributeId = 136,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Capacity()
        {
            return new InformationKey()
            {
                AttributeId = 137,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey FaxAsString()
        {
            return new InformationKey()
            {
                AttributeId = 138,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumSeats()
        {
            return new InformationKey()
            {
                AttributeId = 139,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey PhoneNumberReception()
        {
            return new InformationKey()
            {
                AttributeId = 142,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey AreaCodeReception()
        {
            return new InformationKey()
            {
                AttributeId = 143,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey CountryCodeReception()
        {
            return new InformationKey()
            {
                AttributeId = 144,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey PhoneNumberBooking()
        {
            return new InformationKey()
            {
                AttributeId = 145,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey AreaCodeBooking()
        {
            return new InformationKey()
            {
                AttributeId = 146,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey CountryCodeBooking()
        {
            return new InformationKey()
            {
                AttributeId = 147,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey CheckInStart()
        {
            return new InformationKey()
            {
                AttributeId = 148,
                Culture = _culture.ToString()
            };
        }

        public InformationKey CheckOutEnd()
        {
            return new InformationKey()
            {
                AttributeId = 149,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Link360()
        {
            return new InformationKey()
            {
                AttributeId = 150,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Classification()
        {
            return new InformationKey()
            {
                AttributeId = 151,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey ExternalLinks()
        {
            return new InformationKey()
            {
                AttributeId = 152,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey ContactPersonName()
        {
            return new InformationKey()
            {
                AttributeId = 160,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey ContactPersonEmail()
        {
            return new InformationKey()
            {
                AttributeId = 161,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey ContactPersonNotes()
        {
            return new InformationKey()
            {
                AttributeId = 162,
                Culture = _culture.ToString()
            };
        }

        public InformationKey NumberOfDoublerooms()
        {
            return new InformationKey()
            {
                AttributeId = 166,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumberOfSuites()
        {
            return new InformationKey()
            {
                AttributeId = 167,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumberOfRoomsWithJacuzzi()
        {
            return new InformationKey()
            {
                AttributeId = 168,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumberOfCommunityRooms()
        {
            return new InformationKey()
            {
                AttributeId = 169,
                Culture = _culture.ToString()
            };
        }

        public InformationKey NumberOfDisabledRooms()
        {
            return new InformationKey()
            {
                AttributeId = 170,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumberOfSingleRooms()
        {
            return new InformationKey()
            {
                AttributeId = 171,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey MaxInCinema()
        {
            return new InformationKey()
            {
                AttributeId = 172,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey MaxInSchool()
        {
            return new InformationKey()
            {
                AttributeId = 173,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumberOfGroupRooms()
        {
            return new InformationKey()
            {
                AttributeId = 174,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey KitchenDescription()
        {
            return new InformationKey()
            {
                AttributeId = 175,
                Culture = _culture.ToString()
            };
        }

        public InformationKey History()
        {
            return new InformationKey()
            {
                AttributeId = 177,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Activities()
        {
            return new InformationKey()
            {
                AttributeId = 179,
                Culture = _culture.ToString()
            };
        }

        public InformationKey County()
        {
            return new InformationKey()
            {
                AttributeId = 180,
                Culture = _culture.ToString()
            };
        }

        public InformationKey EditorNotes()
        {
            return new InformationKey()
            {
                AttributeId = 181,
                Culture = _culture.ToString()
            };
        }

        public InformationKey OpeningHoursReception()
        {
            return new InformationKey()
            {
                AttributeId = 193,
                Culture = _culture.ToString()
            };
        }

        public InformationKey WorthSeeing()
        {
            return new InformationKey()
            {
                AttributeId = 194,
                Culture = _culture.ToString()
            };
        }

        public InformationKey RoomsInMultipleBuildings()
        {
            return new InformationKey()
            {
                AttributeId = 196,
                Culture = _culture.ToString()
            };
        }

        public InformationKey ConferenceDescription()
        {
            return new InformationKey()
            {
                AttributeId = 197,
                Culture = _culture.ToString()
            };
        }

        public InformationKey NumberOfFamilyRooms()
        {
            return new InformationKey()
            {
                AttributeId = 198,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumberOfDogRooms()
        {
            return new InformationKey()
            {
                AttributeId = 199,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumberOfStudyRooms()
        {
            return new InformationKey()
            {
                AttributeId = 200,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey EmailBooking()
        {
            return new InformationKey()
            {
                AttributeId = 201,
                Culture = _culture.ToString()
            };
        }

        public InformationKey FaxBookingString()
        {
            return new InformationKey()
            {
                AttributeId = 202,
                Culture = _culture.ToString()
            };
        }

        public InformationKey OtherPhoneString()
        {
            return new InformationKey()
            {
                AttributeId = 203,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey OtherPhoneDetails()
        {
            return new InformationKey()
            {
                AttributeId = 204,
                Culture = _culture.ToString()
            };
        }

        public InformationKey MaxNoofConfPart()
        {
            return new InformationKey()
            {
                AttributeId = 207,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Noofpeopleinbiggestconferenceroom()
        {
            return new InformationKey()
            {
                AttributeId = 208,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Conferencesalespersonname()
        {
            return new InformationKey()
            {
                AttributeId = 211,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Conferencesalespersonphone()
        {
            return new InformationKey()
            {
                AttributeId = 212,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Conferencesalescellphone()
        {
            return new InformationKey()
            {
                AttributeId = 213,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Conferencesalesemail()
        {
            return new InformationKey()
            {
                AttributeId = 214,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Conferencesalespersonname2()
        {
            return new InformationKey()
            {
                AttributeId = 215,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Conferencesalesphone2()
        {
            return new InformationKey()
            {
                AttributeId = 216,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Conferencesalescellphone2()
        {
            return new InformationKey()
            {
                AttributeId = 217,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Conferencesalesemail2()
        {
            return new InformationKey()
            {
                AttributeId = 218,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Noofpepsinislands()
        {
            return new InformationKey()
            {
                AttributeId = 219,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Noofpepsinuseating()
        {
            return new InformationKey()
            {
                AttributeId = 220,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Noofroomsforconfparticipants()
        {
            return new InformationKey()
            {
                AttributeId = 221,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Noofbedsforconfparticipants()
        {
            return new InformationKey()
            {
                AttributeId = 222,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Maxnoofpepsinrestaurant()
        {
            return new InformationKey()
            {
                AttributeId = 225,
                Culture = _culture.ToString()
            };
        }

        public InformationKey OrganizerName()
        {
            return new InformationKey()
            {
                AttributeId = 261,
                Culture = _culture.ToString()
            };
        }

        public InformationKey CoOrganizer()
        {
            return new InformationKey()
            {
                AttributeId = 262,
                Culture = _culture.ToString()
            };
        }

        public InformationKey ReceivingCultureFunds()
        {
            return new InformationKey()
            {
                AttributeId = 263,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Applicationdeadline()
        {
            return new InformationKey()
            {
                AttributeId = 266,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Membershiprequired()
        {
            return new InformationKey()
            {
                AttributeId = 268,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Signuprequired()
        {
            return new InformationKey()
            {
                AttributeId = 269,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Externalsignuptext()
        {
            return new InformationKey()
            {
                AttributeId = 270,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Externalsignuplink()
        {
            return new InformationKey()
            {
                AttributeId = 271,
                Culture = _culture.ToString()
            };
        }

        public InformationKey PhoneNumberBookingString()
        {
            return new InformationKey()
            {
                AttributeId = 273,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey CopyText()
        {
            return new InformationKey()
            {
                AttributeId = 274,
                Culture = _culture.ToString()
            };
        }

        public InformationKey IncludedInCooperation()
        {
            return new InformationKey()
            {
                AttributeId = 275,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey SuitableForDisabled()
        {
            return new InformationKey()
            {
                AttributeId = 276,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey SignupListEmail()
        {
            return new InformationKey()
            {
                AttributeId = 288,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Maxnumberofaccommodation()
        {
            return new InformationKey()
            {
                AttributeId = 291,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Zoomlevel()
        {
            return new InformationKey()
            {
                AttributeId = 297,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumberOfPeopleSocializing()
        {
            return new InformationKey()
            {
                AttributeId = 301,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumberOfSeatsOutside()
        {
            return new InformationKey()
            {
                AttributeId = 302,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Vimeolink()
        {
            return new InformationKey()
            {
                AttributeId = 303,
                Culture = _culture.ToString()
            };
        }

        public InformationKey UniqueSellingPoint1()
        {
            return new InformationKey()
            {
                AttributeId = 304,
                Culture = _culture.ToString()
            };
        }

        public InformationKey UniqueSellingPoint2()
        {
            return new InformationKey()
            {
                AttributeId = 305,
                Culture = _culture.ToString()
            };
        }

        public InformationKey UniqueSellingPoint3()
        {
            return new InformationKey()
            {
                AttributeId = 306,
                Culture = _culture.ToString()
            };
        }

        public InformationKey DistanceFrom()
        {
            return new InformationKey()
            {
                AttributeId = 309,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Km()
        {
            return new InformationKey()
            {
                AttributeId = 310,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey MenuLink()
        {
            return new InformationKey()
            {
                AttributeId = 314,
                Culture = _culture.ToString()
            };
        }

        public InformationKey GeneralRules()
        {
            return new InformationKey()
            {
                AttributeId = 316,
                Culture = _culture.ToString()
            };
        }

        public InformationKey FacilitiesText()
        {
            return new InformationKey()
            {
                AttributeId = 322,
                Culture = _culture.ToString()
            };
        }

        public InformationKey CommercialMessage()
        {
            return new InformationKey()
            {
                AttributeId = 324,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Information1()
        {
            return new InformationKey()
            {
                AttributeId = 325,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Information2()
        {
            return new InformationKey()
            {
                AttributeId = 326,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Information3()
        {
            return new InformationKey()
            {
                AttributeId = 327,
                Culture = _culture.ToString()
            };
        }

        public InformationKey DisabledFacilitiesText()
        {
            return new InformationKey()
            {
                AttributeId = 328,
                Culture = _culture.ToString()
            };
        }

        public InformationKey ApproximatePrice()
        {
            return new InformationKey()
            {
                AttributeId = 329,
                Culture = _culture.ToString()
            };
        }

        public InformationKey ComplementPrice()
        {
            return new InformationKey()
            {
                AttributeId = 330,
                Culture = _culture.ToString()
            };
        }

        public InformationKey FreeEntrance()
        {
            return new InformationKey()
            {
                AttributeId = 331,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey FreeEntranceText()
        {
            return new InformationKey()
            {
                AttributeId = 332,
                Culture = _culture.ToString()
            };
        }

        public InformationKey NantesPass()
        {
            return new InformationKey()
            {
                AttributeId = 333,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NantesPassText()
        {
            return new InformationKey()
            {
                AttributeId = 334,
                Culture = _culture.ToString()
            };
        }

        public InformationKey GroupBenefitTitle()
        {
            return new InformationKey()
            {
                AttributeId = 335,
                Culture = _culture.ToString()
            };
        }

        public InformationKey GroupBenefitDescription()
        {
            return new InformationKey()
            {
                AttributeId = 336,
                Culture = _culture.ToString()
            };
        }

        public InformationKey GroupBenefitContact()
        {
            return new InformationKey()
            {
                AttributeId = 337,
                Culture = _culture.ToString()
            };
        }

        public InformationKey GroupBenefitLink()
        {
            return new InformationKey()
            {
                AttributeId = 338,
                Culture = _culture.ToString()
            };
        }

        public InformationKey GroupBenefitLinkText()
        {
            return new InformationKey()
            {
                AttributeId = 339,
                Culture = _culture.ToString()
            };
        }

        public InformationKey BusinessBenefitTitle()
        {
            return new InformationKey()
            {
                AttributeId = 340,
                Culture = _culture.ToString()
            };
        }

        public InformationKey BusinessBenefitDescription()
        {
            return new InformationKey()
            {
                AttributeId = 341,
                Culture = _culture.ToString()
            };
        }

        public InformationKey BusinessBenefit()
        {
            return new InformationKey()
            {
                AttributeId = 342,
                Culture = _culture.ToString()
            };
        }

        public InformationKey BusinessBenefitLink()
        {
            return new InformationKey()
            {
                AttributeId = 343,
                Culture = _culture.ToString()
            };
        }

        public InformationKey BusinessBenefitLinkText()
        {
            return new InformationKey()
            {
                AttributeId = 344,
                Culture = _culture.ToString()
            };
        }

        public InformationKey CouncilPublisher()
        {
            return new InformationKey()
            {
                AttributeId = 345,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey CouncilPublisherText()
        {
            return new InformationKey()
            {
                AttributeId = 346,
                Culture = _culture.ToString()
            };
        }

        public InformationKey OtherLink()
        {
            return new InformationKey()
            {
                AttributeId = 347,
                Culture = _culture.ToString()
            };
        }

        public InformationKey OtherLinkText()
        {
            return new InformationKey()
            {
                AttributeId = 348,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Municipality()
        {
            return new InformationKey()
            {
                AttributeId = 356,
                Culture = _culture.ToString()
            };
        }

        public InformationKey MeetingPoint()
        {
            return new InformationKey()
            {
                AttributeId = 357,
                Culture = _culture.ToString()
            };
        }

        public InformationKey MeetingTime()
        {
            return new InformationKey()
            {
                AttributeId = 358,
                Culture = _culture.ToString()
            };
        }

        public InformationKey NumberOfDepartures()
        {
            return new InformationKey()
            {
                AttributeId = 361,
                Culture = _culture.ToString()
            };
        }

        public InformationKey TimeForDeparture()
        {
            return new InformationKey()
            {
                AttributeId = 362,
                Culture = _culture.ToString()
            };
        }

        public InformationKey StartPoint()
        {
            return new InformationKey()
            {
                AttributeId = 364,
                Culture = _culture.ToString()
            };
        }

        public InformationKey TransportTime()
        {
            return new InformationKey()
            {
                AttributeId = 366,
                Culture = _culture.ToString()
            };
        }

        public InformationKey NumberOfRoom()
        {
            return new InformationKey()
            {
                AttributeId = 371,
                Culture = _culture.ToString()
            };
        }

        public InformationKey NumberOfBeds()
        {
            return new InformationKey()
            {
                AttributeId = 372,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey YoungestParticipants()
        {
            return new InformationKey()
            {
                AttributeId = 373,
                Culture = _culture.ToString()
            };
        }

        public InformationKey MinWeight()
        {
            return new InformationKey()
            {
                AttributeId = 374,
                Culture = _culture.ToString()
            };
        }

        public InformationKey MinHight()
        {
            return new InformationKey()
            {
                AttributeId = 375,
                Culture = _culture.ToString()
            };
        }

        public InformationKey MiniAgeYoung()
        {
            return new InformationKey()
            {
                AttributeId = 381,
                Culture = _culture.ToString()
            };
        }

        public InformationKey MinWeightYoung()
        {
            return new InformationKey()
            {
                AttributeId = 382,
                Culture = _culture.ToString()
            };
        }

        public InformationKey MaxWeightYoung()
        {
            return new InformationKey()
            {
                AttributeId = 383,
                Culture = _culture.ToString()
            };
        }

        public InformationKey MiniAgeAdult()
        {
            return new InformationKey()
            {
                AttributeId = 384,
                Culture = _culture.ToString()
            };
        }

        public InformationKey MinWeightAdult()
        {
            return new InformationKey()
            {
                AttributeId = 385,
                Culture = _culture.ToString()
            };
        }

        public InformationKey MaxWeightAdult()
        {
            return new InformationKey()
            {
                AttributeId = 386,
                Culture = _culture.ToString()
            };
        }

        public InformationKey TransportFrom()
        {
            return new InformationKey()
            {
                AttributeId = 387,
                Culture = _culture.ToString()
            };
        }

        public InformationKey TransportTo()
        {
            return new InformationKey()
            {
                AttributeId = 388,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Equipment()
        {
            return new InformationKey()
            {
                AttributeId = 389,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Currency()
        {
            return new InformationKey()
            {
                AttributeId = 402,
                Culture = _culture.ToString()
            };
        }

        public InformationKey NumberOfCampingSites()
        {
            return new InformationKey()
            {
                AttributeId = 403,
                Culture = _culture.ToString()
            };
        }

        public InformationKey NumberOfRestaurant()
        {
            return new InformationKey()
            {
                AttributeId = 404,
                Culture = _culture.ToString()
            };
        }

        public InformationKey NumberOfAppartments()
        {
            return new InformationKey()
            {
                AttributeId = 405,
                Culture = _culture.ToString()
            };
        }

        public InformationKey SquareMeter()
        {
            return new InformationKey()
            {
                AttributeId = 406,
                Culture = _culture.ToString()
            };
        }

        public InformationKey NumberOfCabins()
        {
            return new InformationKey()
            {
                AttributeId = 407,
                Culture = _culture.ToString()
            };
        }

        public InformationKey PriceDescription()
        {
            return new InformationKey()
            {
                AttributeId = 415,
                Culture = _culture.ToString()
            };
        }

        public InformationKey CellNumberContact()
        {
            return new InformationKey()
            {
                AttributeId = 419,
                Culture = _culture.ToString()
            };
        }

        public InformationKey PhoneNumber()
        {
            return new InformationKey()
            {
                AttributeId = 421,
                Culture = _culture.ToString()
            };
        }

        public InformationKey PriceTo()
        {
            return new InformationKey()
            {
                AttributeId = 422,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Population()
        {
            return new InformationKey()
            {
                AttributeId = 424,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Newspapers()
        {
            return new InformationKey()
            {
                AttributeId = 425,
                Culture = _culture.ToString()
            };
        }

        public InformationKey DestinationIso()
        {
            return new InformationKey()
            {
                AttributeId = 428,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey AirportsIata()
        {
            return new InformationKey()
            {
                AttributeId = 429,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Continent()
        {
            return new InformationKey()
            {
                AttributeId = 430,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey CheckInLatest()
        {
            return new InformationKey()
            {
                AttributeId = 432,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Sponsored()
        {
            return new InformationKey()
            {
                AttributeId = 434,
                Culture = _culture.ToString()
            };
        }

        public InformationKey TitlePartner()
        {
            return new InformationKey()
            {
                AttributeId = 436,
                Culture = _culture.ToString()
            };
        }

        public InformationKey DescriptionPartner()
        {
            return new InformationKey()
            {
                AttributeId = 437,
                Culture = _culture.ToString()
            };
        }

        public InformationKey ContactPartner()
        {
            return new InformationKey()
            {
                AttributeId = 438,
                Culture = _culture.ToString()
            };
        }

        public InformationKey WebSitePartner()
        {
            return new InformationKey()
            {
                AttributeId = 439,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Partner()
        {
            return new InformationKey()
            {
                AttributeId = 440,
                Culture = _culture.ToString()
            };
        }

        public InformationKey State()
        {
            return new InformationKey()
            {
                AttributeId = 522,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumberOfToilets()
        {
            return new InformationKey()
            {
                AttributeId = 591,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumberOfShowers()
        {
            return new InformationKey()
            {
                AttributeId = 592,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey DistanceToNearestCityInMeters()
        {
            return new InformationKey()
            {
                AttributeId = 593,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey DistanceToNearestAlpineSlopeInMeters()
        {
            return new InformationKey()
            {
                AttributeId = 594,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey DistanceToNearestCrossCountryInMeters()
        {
            return new InformationKey()
            {
                AttributeId = 595,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey DistanceToNearestRiverInMeters()
        {
            return new InformationKey()
            {
                AttributeId = 596,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey DistanceToNearestCoastInMeters()
        {
            return new InformationKey()
            {
                AttributeId = 597,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey DistanceToNearestLakeInMeters()
        {
            return new InformationKey()
            {
                AttributeId = 598,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey DistanceToNearestFishingInMeters()
        {
            return new InformationKey()
            {
                AttributeId = 599,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey DistanceToNearestBathInMeters()
        {
            return new InformationKey()
            {
                AttributeId = 600,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey DistanceToNearestGroceryStoreInMeters()
        {
            return new InformationKey()
            {
                AttributeId = 601,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey DistanceToNearestRestaurantInMeters()
        {
            return new InformationKey()
            {
                AttributeId = 602,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey NumberOfBedrooms()
        {
            return new InformationKey()
            {
                AttributeId = 603,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey Howtogettomeetingpoint()
        {
            return new InformationKey()
            {
                AttributeId = 630,
                Culture = _culture.ToString()
            };
        }

        public InformationKey DistanceToNearestLiftInMeters()
        {
            return new InformationKey()
            {
                AttributeId = 680,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey DistanceToNearestSkiRentalInMeters()
        {
            return new InformationKey()
            {
                AttributeId = 681,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey PaymentInfo()
        {
            return new InformationKey()
            {
                AttributeId = 970,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Facebookpage()
        {
            return new InformationKey()
            {
                AttributeId = 972,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Blogpage()
        {
            return new InformationKey()
            {
                AttributeId = 973,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Instagrampage()
        {
            return new InformationKey()
            {
                AttributeId = 974,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Pinterestpage()
        {
            return new InformationKey()
            {
                AttributeId = 975,
                Culture = _culture.ToString()
            };
        }

        public InformationKey ShowExternalUrl()
        {
            return new InformationKey()
            {
                AttributeId = 979,
                Culture = _culture.ToString()
            };
        }

        public InformationKey Distancecitycentre()
        {
            return new InformationKey()
            {
                AttributeId = 988,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey DistanceBeachKm()
        {
            return new InformationKey()
            {
                AttributeId = 991,
                Culture = CultureInfo.InvariantCulture.ToString()
            };
        }

        public InformationKey PriceFrom()
        {
            return new InformationKey()
            {
                AttributeId = 1012,
                Culture = _culture.ToString()
            };
        }
    }
}
