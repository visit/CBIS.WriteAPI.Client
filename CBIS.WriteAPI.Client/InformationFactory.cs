using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBIS.WriteAPI.Client.Generated;

namespace CBIS.WriteAPI.Client
{
    public class InformationFactory
    {
        public readonly InformationKeyFactory _keyFactory;

        public InformationFactory(CultureInfo culture)
        {
            _keyFactory = new InformationKeyFactory(culture);
        }

        public Information Name(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Name(),
                Value = value
            };
        }

        public Information Introduction(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Introduction(),
                Value = value
            };
        }

        public Information Description(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Description(),
                Value = value
            };
        }

        public Information Direction(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Direction(),
                Value = value
            };
        }

        public Information OpeningHours(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.OpeningHours(),
                Value = value
            };
        }

        public Information Entrence(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Entrence(),
                Value = value
            };
        }

        public Information PhoneNumberString(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.PhoneNumberString(),
                Value = value
            };
        }

        public Information MobilePhoneString(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.MobilePhoneString(),
                Value = value
            };
        }

        public Information Email(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Email(),
                Value = value
            };
        }

        public Information Website(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Website(),
                Value = value
            };
        }

        public Information Other(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Other(),
                Value = value
            };
        }

        public Information Latitude(double value)
        {
            return new InformationDouble()
            {
                Attribute = _keyFactory.Latitude(),
                Value = value
            };
        }

        public Information Longitude(double value)
        {
            return new InformationDouble()
            {
                Attribute = _keyFactory.Longitude(),
                Value = value
            };
        }

        public Information StreetAddress1(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.StreetAddress1(),
                Value = value
            };
        }

        public Information StreetAddress2(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.StreetAddress2(),
                Value = value
            };
        }

        public Information StreetAddress3(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.StreetAddress3(),
                Value = value
            };
        }

        public Information PostalCode(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.PostalCode(),
                Value = value
            };
        }

        public Information CityAddress(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.CityAddress(),
                Value = value
            };
        }

        public Information CountryAddress(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.CountryAddress(),
                Value = value
            };
        }

        public Information EventType(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.EventType(),
                Value = value
            };
        }

        public Information EventUrl(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.EventUrl(),
                Value = value
            };
        }

        public Information BookUrl(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.BookUrl(),
                Value = value
            };
        }

        public Information AgeLimit(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.AgeLimit(),
                Value = value
            };
        }

        public Information NumRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumRooms(),
                Value = value
            };
        }

        public Information NumFloors(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumFloors(),
                Value = value
            };
        }

        public Information NumConferenceRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumConferenceRooms(),
                Value = value
            };
        }

        public Information NumBars(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumBars(),
                Value = value
            };
        }

        public Information YearBuilt(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.YearBuilt(),
                Value = value
            };
        }

        public Information LastRenovatedYear(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.LastRenovatedYear(),
                Value = value
            };
        }

        public Information KeyPickup(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.KeyPickup(),
                Value = value
            };
        }

        public Information Capacity(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.Capacity(),
                Value = value
            };
        }

        public Information FaxAsString(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.FaxAsString(),
                Value = value
            };
        }

        public Information NumSeats(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumSeats(),
                Value = value
            };
        }

        public Information PhoneNumberReception(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.PhoneNumberReception(),
                Value = value
            };
        }

        public Information AreaCodeReception(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.AreaCodeReception(),
                Value = value
            };
        }

        public Information CountryCodeReception(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.CountryCodeReception(),
                Value = value
            };
        }

        public Information PhoneNumberBooking(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.PhoneNumberBooking(),
                Value = value
            };
        }

        public Information AreaCodeBooking(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.AreaCodeBooking(),
                Value = value
            };
        }

        public Information CountryCodeBooking(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.CountryCodeBooking(),
                Value = value
            };
        }

        public Information CheckInStart(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.CheckInStart(),
                Value = value
            };
        }

        public Information CheckOutEnd(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.CheckOutEnd(),
                Value = value
            };
        }

        public Information Link360(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Link360(),
                Value = value
            };
        }

        public Information Classification(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.Classification(),
                Value = value
            };
        }

        public Information ExternalLinks(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.ExternalLinks(),
                Value = value
            };
        }

        public Information ContactPersonName(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.ContactPersonName(),
                Value = value
            };
        }

        public Information ContactPersonEmail(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.ContactPersonEmail(),
                Value = value
            };
        }

        public Information ContactPersonNotes(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.ContactPersonNotes(),
                Value = value
            };
        }

        public Information NumberOfDoublerooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfDoublerooms(),
                Value = value
            };
        }

        public Information NumberOfSuites(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfSuites(),
                Value = value
            };
        }

        public Information NumberOfRoomsWithJacuzzi(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfRoomsWithJacuzzi(),
                Value = value
            };
        }

        public Information NumberOfCommunityRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfCommunityRooms(),
                Value = value
            };
        }

        public Information NumberOfDisabledRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfDisabledRooms(),
                Value = value
            };
        }

        public Information NumberOfSingleRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfSingleRooms(),
                Value = value
            };
        }

        public Information MaxInCinema(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.MaxInCinema(),
                Value = value
            };
        }

        public Information MaxInSchool(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.MaxInSchool(),
                Value = value
            };
        }

        public Information NumberOfGroupRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfGroupRooms(),
                Value = value
            };
        }

        public Information KitchenDescription(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.KitchenDescription(),
                Value = value
            };
        }

        public Information History(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.History(),
                Value = value
            };
        }

        public Information Activities(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Activities(),
                Value = value
            };
        }

        public Information County(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.County(),
                Value = value
            };
        }

        public Information EditorNotes(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.EditorNotes(),
                Value = value
            };
        }

        public Information OpeningHoursReception(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.OpeningHoursReception(),
                Value = value
            };
        }

        public Information WorthSeeing(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.WorthSeeing(),
                Value = value
            };
        }

        public Information RoomsInMultipleBuildings(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.RoomsInMultipleBuildings(),
                Value = value
            };
        }

        public Information ConferenceDescription(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.ConferenceDescription(),
                Value = value
            };
        }

        public Information NumberOfFamilyRooms(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.NumberOfFamilyRooms(),
                Value = value
            };
        }

        public Information NumberOfDogRooms(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.NumberOfDogRooms(),
                Value = value
            };
        }

        public Information NumberOfStudyRooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfStudyRooms(),
                Value = value
            };
        }

        public Information EmailBooking(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.EmailBooking(),
                Value = value
            };
        }

        public Information FaxBookingString(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.FaxBookingString(),
                Value = value
            };
        }

        public Information OtherPhoneString(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.OtherPhoneString(),
                Value = value
            };
        }

        public Information OtherPhoneDetails(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.OtherPhoneDetails(),
                Value = value
            };
        }

        public Information MaxNoofConfPart(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.MaxNoofConfPart(),
                Value = value
            };
        }

        public Information Noofpeopleinbiggestconferenceroom(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Noofpeopleinbiggestconferenceroom(),
                Value = value
            };
        }

        public Information Conferencesalespersonname(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Conferencesalespersonname(),
                Value = value
            };
        }

        public Information Conferencesalespersonphone(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Conferencesalespersonphone(),
                Value = value
            };
        }

        public Information Conferencesalescellphone(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Conferencesalescellphone(),
                Value = value
            };
        }

        public Information Conferencesalesemail(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Conferencesalesemail(),
                Value = value
            };
        }

        public Information Conferencesalespersonname2(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Conferencesalespersonname2(),
                Value = value
            };
        }

        public Information Conferencesalesphone2(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Conferencesalesphone2(),
                Value = value
            };
        }

        public Information Conferencesalescellphone2(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Conferencesalescellphone2(),
                Value = value
            };
        }

        public Information Conferencesalesemail2(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Conferencesalesemail2(),
                Value = value
            };
        }

        public Information Noofpepsinislands(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.Noofpepsinislands(),
                Value = value
            };
        }

        public Information Noofpepsinuseating(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.Noofpepsinuseating(),
                Value = value
            };
        }

        public Information Noofroomsforconfparticipants(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.Noofroomsforconfparticipants(),
                Value = value
            };
        }

        public Information Noofbedsforconfparticipants(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.Noofbedsforconfparticipants(),
                Value = value
            };
        }

        public Information Maxnoofpepsinrestaurant(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.Maxnoofpepsinrestaurant(),
                Value = value
            };
        }

        public Information OrganizerName(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.OrganizerName(),
                Value = value
            };
        }

        public Information CoOrganizer(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.CoOrganizer(),
                Value = value
            };
        }

        public Information ReceivingCultureFunds(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = _keyFactory.ReceivingCultureFunds(),
                Value = value
            };
        }

        public Information Applicationdeadline(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Applicationdeadline(),
                Value = value
            };
        }

        public Information Membershiprequired(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = _keyFactory.Membershiprequired(),
                Value = value
            };
        }

        public Information Signuprequired(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = _keyFactory.Signuprequired(),
                Value = value
            };
        }

        public Information Externalsignuptext(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Externalsignuptext(),
                Value = value
            };
        }

        public Information Externalsignuplink(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Externalsignuplink(),
                Value = value
            };
        }

        public Information PhoneNumberBookingString(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.PhoneNumberBookingString(),
                Value = value
            };
        }

        public Information CopyText(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.CopyText(),
                Value = value
            };
        }

        public Information IncludedInCooperation(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = _keyFactory.IncludedInCooperation(),
                Value = value
            };
        }

        public Information SuitableForDisabled(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = _keyFactory.SuitableForDisabled(),
                Value = value
            };
        }

        public Information SignupListEmail(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.SignupListEmail(),
                Value = value
            };
        }

        public Information Maxnumberofaccommodation(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Maxnumberofaccommodation(),
                Value = value
            };
        }

        public Information Zoomlevel(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.Zoomlevel(),
                Value = value
            };
        }

        public Information NumberOfPeopleSocializing(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfPeopleSocializing(),
                Value = value
            };
        }

        public Information NumberOfSeatsOutside(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfSeatsOutside(),
                Value = value
            };
        }

        public Information Vimeolink(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Vimeolink(),
                Value = value
            };
        }

        public Information UniqueSellingPoint1(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.UniqueSellingPoint1(),
                Value = value
            };
        }

        public Information UniqueSellingPoint2(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.UniqueSellingPoint2(),
                Value = value
            };
        }

        public Information UniqueSellingPoint3(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.UniqueSellingPoint3(),
                Value = value
            };
        }

        public Information DistanceFrom(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceFrom(),
                Value = value
            };
        }

        public Information Km(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.Km(),
                Value = value
            };
        }

        public Information MenuLink(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.MenuLink(),
                Value = value
            };
        }

        public Information GeneralRules(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.GeneralRules(),
                Value = value
            };
        }

        public Information FacilitiesText(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.FacilitiesText(),
                Value = value
            };
        }

        public Information CommercialMessage(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.CommercialMessage(),
                Value = value
            };
        }

        public Information Information1(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Information1(),
                Value = value
            };
        }

        public Information Information2(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Information2(),
                Value = value
            };
        }

        public Information Information3(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Information3(),
                Value = value
            };
        }

        public Information DisabledFacilitiesText(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.DisabledFacilitiesText(),
                Value = value
            };
        }

        public Information ApproximatePrice(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.ApproximatePrice(),
                Value = value
            };
        }

        public Information ComplementPrice(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.ComplementPrice(),
                Value = value
            };
        }

        public Information FreeEntrance(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = _keyFactory.FreeEntrance(),
                Value = value
            };
        }

        public Information FreeEntranceText(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.FreeEntranceText(),
                Value = value
            };
        }

        public Information NantesPass(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = _keyFactory.NantesPass(),
                Value = value
            };
        }

        public Information NantesPassText(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.NantesPassText(),
                Value = value
            };
        }

        public Information GroupBenefitTitle(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.GroupBenefitTitle(),
                Value = value
            };
        }

        public Information GroupBenefitDescription(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.GroupBenefitDescription(),
                Value = value
            };
        }

        public Information GroupBenefitContact(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.GroupBenefitContact(),
                Value = value
            };
        }

        public Information GroupBenefitLink(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.GroupBenefitLink(),
                Value = value
            };
        }

        public Information GroupBenefitLinkText(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.GroupBenefitLinkText(),
                Value = value
            };
        }

        public Information BusinessBenefitTitle(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.BusinessBenefitTitle(),
                Value = value
            };
        }

        public Information BusinessBenefitDescription(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.BusinessBenefitDescription(),
                Value = value
            };
        }

        public Information BusinessBenefit(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.BusinessBenefit(),
                Value = value
            };
        }

        public Information BusinessBenefitLink(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.BusinessBenefitLink(),
                Value = value
            };
        }

        public Information BusinessBenefitLinkText(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.BusinessBenefitLinkText(),
                Value = value
            };
        }

        public Information CouncilPublisher(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = _keyFactory.CouncilPublisher(),
                Value = value
            };
        }

        public Information CouncilPublisherText(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.CouncilPublisherText(),
                Value = value
            };
        }

        public Information OtherLink(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.OtherLink(),
                Value = value
            };
        }

        public Information OtherLinkText(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.OtherLinkText(),
                Value = value
            };
        }

        public Information Municipality(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Municipality(),
                Value = value
            };
        }

        public Information MeetingPoint(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.MeetingPoint(),
                Value = value
            };
        }

        public Information MeetingTime(double value)
        {
            return new InformationDouble()
            {
                Attribute = _keyFactory.MeetingTime(),
                Value = value
            };
        }

        public Information NumberOfDepartures(double value)
        {
            return new InformationDouble()
            {
                Attribute = _keyFactory.NumberOfDepartures(),
                Value = value
            };
        }

        public Information TimeForDeparture(double value)
        {
            return new InformationDouble()
            {
                Attribute = _keyFactory.TimeForDeparture(),
                Value = value
            };
        }

        public Information StartPoint(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.StartPoint(),
                Value = value
            };
        }

        public Information TransportTime(double value)
        {
            return new InformationDouble()
            {
                Attribute = _keyFactory.TransportTime(),
                Value = value
            };
        }

        public Information NumberOfRoom(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfRoom(),
                Value = value
            };
        }

        public Information NumberOfBeds(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfBeds(),
                Value = value
            };
        }

        public Information YoungestParticipants(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.YoungestParticipants(),
                Value = value
            };
        }

        public Information MinWeight(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.MinWeight(),
                Value = value
            };
        }

        public Information MinHight(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.MinHight(),
                Value = value
            };
        }

        public Information MiniAgeYoung(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.MiniAgeYoung(),
                Value = value
            };
        }

        public Information MinWeightYoung(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.MinWeightYoung(),
                Value = value
            };
        }

        public Information MaxWeightYoung(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.MaxWeightYoung(),
                Value = value
            };
        }

        public Information MiniAgeAdult(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.MiniAgeAdult(),
                Value = value
            };
        }

        public Information MinWeightAdult(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.MinWeightAdult(),
                Value = value
            };
        }

        public Information MaxWeightAdult(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.MaxWeightAdult(),
                Value = value
            };
        }

        public Information TransportFrom(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.TransportFrom(),
                Value = value
            };
        }

        public Information TransportTo(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.TransportTo(),
                Value = value
            };
        }

        public Information Equipment(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Equipment(),
                Value = value
            };
        }

        public Information Currency(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Currency(),
                Value = value
            };
        }

        public Information NumberOfCampingSites(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfCampingSites(),
                Value = value
            };
        }

        public Information NumberOfRestaurant(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfRestaurant(),
                Value = value
            };
        }

        public Information NumberOfAppartments(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfAppartments(),
                Value = value
            };
        }

        public Information SquareMeter(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.SquareMeter(),
                Value = value
            };
        }

        public Information NumberOfCabins(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfCabins(),
                Value = value
            };
        }

        public Information PriceDescription(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.PriceDescription(),
                Value = value
            };
        }

        public Information CellNumberContact(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.CellNumberContact(),
                Value = value
            };
        }

        public Information PhoneNumber(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.PhoneNumber(),
                Value = value
            };
        }

        public Information PriceTo(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.PriceTo(),
                Value = value
            };
        }

        public Information Population(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Population(),
                Value = value
            };
        }

        public Information Newspapers(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Newspapers(),
                Value = value
            };
        }

        public Information DestinationIso(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.DestinationIso(),
                Value = value
            };
        }

        public Information AirportsIata(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.AirportsIata(),
                Value = value
            };
        }

        public Information Continent(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Continent(),
                Value = value
            };
        }

        public Information CheckInLatest(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.CheckInLatest(),
                Value = value
            };
        }

        public Information Sponsored(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = _keyFactory.Sponsored(),
                Value = value
            };
        }

        public Information TitlePartner(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.TitlePartner(),
                Value = value
            };
        }

        public Information DescriptionPartner(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.DescriptionPartner(),
                Value = value
            };
        }

        public Information ContactPartner(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.ContactPartner(),
                Value = value
            };
        }

        public Information WebSitePartner(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.WebSitePartner(),
                Value = value
            };
        }

        public Information Partner(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Partner(),
                Value = value
            };
        }

        public Information State(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.State(),
                Value = value
            };
        }

        public Information NumberOfToilets(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfToilets(),
                Value = value
            };
        }

        public Information NumberOfShowers(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfShowers(),
                Value = value
            };
        }

        public Information DistanceToNearestCityInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceToNearestCityInMeters(),
                Value = value
            };
        }

        public Information DistanceToNearestAlpineSlopeInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceToNearestAlpineSlopeInMeters(),
                Value = value
            };
        }

        public Information DistanceToNearestCrossCountryInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceToNearestCrossCountryInMeters(),
                Value = value
            };
        }

        public Information DistanceToNearestRiverInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceToNearestRiverInMeters(),
                Value = value
            };
        }

        public Information DistanceToNearestCoastInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceToNearestCoastInMeters(),
                Value = value
            };
        }

        public Information DistanceToNearestLakeInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceToNearestLakeInMeters(),
                Value = value
            };
        }

        public Information DistanceToNearestFishingInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceToNearestFishingInMeters(),
                Value = value
            };
        }

        public Information DistanceToNearestBathInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceToNearestBathInMeters(),
                Value = value
            };
        }

        public Information DistanceToNearestGroceryStoreInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceToNearestGroceryStoreInMeters(),
                Value = value
            };
        }

        public Information DistanceToNearestRestaurantInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceToNearestRestaurantInMeters(),
                Value = value
            };
        }

        public Information NumberOfBedrooms(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.NumberOfBedrooms(),
                Value = value
            };
        }

        public Information Howtogettomeetingpoint(bool value)
        {
            return new InformationBoolean()
            {
                Attribute = _keyFactory.Howtogettomeetingpoint(),
                Value = value
            };
        }

        public Information DistanceToNearestLiftInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceToNearestLiftInMeters(),
                Value = value
            };
        }

        public Information DistanceToNearestSkiRentalInMeters(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceToNearestSkiRentalInMeters(),
                Value = value
            };
        }

        public Information PaymentInfo(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.PaymentInfo(),
                Value = value
            };
        }

        public Information Facebookpage(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Facebookpage(),
                Value = value
            };
        }

        public Information Blogpage(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Blogpage(),
                Value = value
            };
        }

        public Information Instagrampage(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Instagrampage(),
                Value = value
            };
        }

        public Information Pinterestpage(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.Pinterestpage(),
                Value = value
            };
        }

        public Information ShowExternalUrl(string value)
        {
            return new InformationString()
            {
                Attribute = _keyFactory.ShowExternalUrl(),
                Value = value
            };
        }

        public Information Distancecitycentre(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.Distancecitycentre(),
                Value = value
            };
        }

        public Information DistanceBeachKm(int value)
        {
            return new InformationInteger()
            {
                Attribute = _keyFactory.DistanceBeachKm(),
                Value = value
            };
        }

        public Information PriceFrom(double value)
        {
            return new InformationDouble()
            {
                Attribute = _keyFactory.PriceFrom(),
                Value = value
            };
        }
    }
}
