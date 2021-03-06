﻿using System;
using System.Collections.Generic;
using System.Linq;
using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Interfaces.Microsoft.Dynamics.CRM;
using Gov.Lclb.Cllb.Interfaces.Models;
using Gov.Lclb.Cllb.Public.ViewModels;

namespace Gov.Lclb.Cllb.Public.Models
{
    /// <summary>
    /// ViewModel transforms.
    /// </summary>
    public static class Adoxio_LegalEntityExtensions
    {


        /// <summary>
        /// Copy values from a Dynamics legal entity to another one
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        public static void CopyValues(this Adoxio_legalentity to, Adoxio_legalentity from)
        {
            to.Adoxio_legalentityid = from.Adoxio_legalentityid;
            to.Adoxio_commonnonvotingshares = from.Adoxio_commonnonvotingshares;
            to.Adoxio_commonvotingshares = from.Adoxio_commonvotingshares;
            to.Adoxio_dateofbirth = from.Adoxio_dateofbirth;
            to.Adoxio_firstname = from.Adoxio_firstname;
            to.Adoxio_interestpercentage = from.Adoxio_interestpercentage;
            to.Adoxio_isindividual = from.Adoxio_isindividual;
            to.Adoxio_lastname = from.Adoxio_lastname;
            to.Adoxio_legalentitytype = from.Adoxio_legalentitytype;
            to.Adoxio_middlename = from.Adoxio_middlename;
            to.Adoxio_name = from.Adoxio_name;
            to.Adoxio_position = from.Adoxio_position;
            to.Adoxio_ispartner = from.Adoxio_ispartner;
            to.Adoxio_isshareholder = from.Adoxio_isshareholder;
            to.Adoxio_istrustee = from.Adoxio_istrustee;
            to.Adoxio_isdirector = from.Adoxio_isdirector;
            to.Adoxio_isofficer = from.Adoxio_isofficer;
            to.Adoxio_isowner = from.Adoxio_isowner;
            to.Adoxio_preferrednonvotingshares = from.Adoxio_preferrednonvotingshares;
            to.Adoxio_preferredvotingshares = from.Adoxio_preferredvotingshares;
            to.Adoxio_sameasapplyingperson = from.Adoxio_sameasapplyingperson;
            to.Adoxio_dateofappointment = from.Adoxio_dateofappointment;
        }

        /// <summary>
        /// Copy values from View Model to Dynamics legal entity
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        public static void CopyValues(this Adoxio_legalentity to, ViewModels.AdoxioLegalEntity from, Interfaces.Microsoft.Dynamics.CRM.System _system)
        {

            to.Adoxio_commonnonvotingshares = from.commonnonvotingshares;
            to.Adoxio_commonvotingshares = from.commonvotingshares;
            to.Adoxio_dateofbirth = from.dateofbirth;
            to.Adoxio_firstname = from.firstname;
            to.Adoxio_interestpercentage = from.interestpercentage;
            to.Adoxio_isindividual = (from.isindividual != null && (bool)from.isindividual) ? 1 : 0;
            to.Adoxio_lastname = from.lastname;
            to.Adoxio_legalentitytype = (int?)from.legalentitytype;
            to.Adoxio_middlename = from.middlename;
            to.Adoxio_name = from.name;
            to.Adoxio_ispartner = (from.isPartner == true);
            to.Adoxio_isshareholder = from.isShareholder;
            to.Adoxio_istrustee = false;
            to.Adoxio_isdirector = from.isDirector;
            to.Adoxio_isofficer = from.isOfficer;
            to.Adoxio_isowner = false;
            to.Adoxio_preferrednonvotingshares = from.preferrednonvotingshares;
            to.Adoxio_preferredvotingshares = from.preferredvotingshares;
            to.Adoxio_sameasapplyingperson = (from.sameasapplyingperson != null && (bool)from.sameasapplyingperson) ? 1 : 0;
            to.Adoxio_email = from.email;
            to.Adoxio_dateofappointment = from.dateofappointment;
            // Assigning the account this way throws exception:
            // System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
            //if (from.account.id != null)
            //{
            //    // fetch the account from Dynamics.
            //    var getAccountTask = _system.GetAccountById(null, Guid.Parse(from.account.id));
            //    getAccountTask.Wait();
            //    to.Adoxio_Account= getAccountTask.Result;
            //}
            // adoxio_dateemailsent
        }


        /// <summary>
        /// Copy values from View Model to Dynamics legal entity
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        public static void CopyValues(this MicrosoftDynamicsCRMadoxioLegalentity to, ViewModels.AdoxioLegalEntity from)
        {

            to.AdoxioCommonnonvotingshares = from.commonnonvotingshares;
            to.AdoxioCommonvotingshares = from.commonvotingshares;
            to.AdoxioDateofbirth = from.dateofbirth;
            to.AdoxioFirstname = from.firstname;
            to.AdoxioInterestpercentage = (double?)from.interestpercentage;
            to.AdoxioIsindividual = (from.isindividual != null && (bool)from.isindividual) ? 1 : 0;
            to.AdoxioLastname = from.lastname;
            if (from.legalentitytype != null)
            {
                to.AdoxioLegalentitytype = (int?)from.legalentitytype;
            }
            to.AdoxioMiddlename = from.middlename;
            to.AdoxioName = from.name;
            to.AdoxioIspartner = from.isPartner;
            to.AdoxioIsshareholder = from.isShareholder;
            to.AdoxioIstrustee = false;
            to.AdoxioIsdirector = from.isDirector;
            to.AdoxioIsofficer = from.isOfficer;
            to.AdoxioIsseniormanagement = from.isSeniorManagement;
            to.AdoxioIsowner = false;
            to.AdoxioPreferrednonvotingshares = from.preferrednonvotingshares;
            to.AdoxioPreferredvotingshares = from.preferredvotingshares;
            to.AdoxioSameasapplyingperson = (from.sameasapplyingperson != null && (bool)from.sameasapplyingperson) ? 1 : 0;
            to.AdoxioEmail = from.email;
            to.AdoxioDateofappointment = from.dateofappointment;
            // Assigning the account this way throws exception:
            // System.InvalidOperationException: Collection was modified; enumeration operation may not execute.
            //if (from.account.id != null)
            //{
            //    // fetch the account from Dynamics.
            //    var getAccountTask = _system.GetAccountById(null, Guid.Parse(from.account.id));
            //    getAccountTask.Wait();
            //    to.Adoxio_Account= getAccountTask.Result;
            //}
            // adoxio_dateemailsent
        }

        /// <summary>
        /// Convert a given voteQuestion to a ViewModel
        /// </summary>        
        public static ViewModels.AdoxioLegalEntity ToViewModel(this Adoxio_legalentity adoxio_legalentity)
        {
            ViewModels.AdoxioLegalEntity result = null;
            if (adoxio_legalentity != null)
            {
                result = new ViewModels.AdoxioLegalEntity();
                if (adoxio_legalentity.Adoxio_legalentityid != null)
                {
                    result.id = adoxio_legalentity.Adoxio_legalentityid.ToString();
                }

                result.isDirector = (adoxio_legalentity.Adoxio_isdirector == true);

                result.commonnonvotingshares = adoxio_legalentity.Adoxio_commonnonvotingshares;
                result.commonvotingshares = adoxio_legalentity.Adoxio_commonvotingshares;
                result.dateofbirth = adoxio_legalentity.Adoxio_dateofbirth;
                result.firstname = adoxio_legalentity.Adoxio_firstname;
                result.interestpercentage = adoxio_legalentity.Adoxio_interestpercentage;
                // convert from int to bool.
                result.isindividual = (adoxio_legalentity.Adoxio_isindividual != null && adoxio_legalentity.Adoxio_isindividual != 0);
                result.lastname = adoxio_legalentity.Adoxio_lastname;
                if (adoxio_legalentity.Adoxio_legalentitytype != null)
                {
                    result.legalentitytype = (Adoxio_applicanttypecodes)adoxio_legalentity.Adoxio_legalentitytype;
                }

                result.middlename = adoxio_legalentity.Adoxio_middlename;
                result.name = adoxio_legalentity.Adoxio_name;
                result.email = adoxio_legalentity.Adoxio_email;

                result.preferrednonvotingshares = adoxio_legalentity.Adoxio_preferrednonvotingshares;
                result.preferredvotingshares = adoxio_legalentity.Adoxio_preferredvotingshares;
                // convert from int to bool.
                result.sameasapplyingperson = (adoxio_legalentity.Adoxio_sameasapplyingperson != null && adoxio_legalentity.Adoxio_sameasapplyingperson != 0);
                result.dateofappointment = adoxio_legalentity.Adoxio_dateofappointment;

                // populate the account.
                if (adoxio_legalentity.Adoxio_Account != null)
                {
                    result.account = adoxio_legalentity.Adoxio_Account.ToViewModel();
                }

                result.accountId = adoxio_legalentity._adoxio_account_value.ToString();

            }
            return result;
        }

        /// <summary>
        /// Convert a Dynamics Legal Entity to a ViewModel
        /// </summary>        
        public static ViewModels.AdoxioLegalEntity ToViewModel(this MicrosoftDynamicsCRMadoxioLegalentity adoxio_legalentity)
        {
            ViewModels.AdoxioLegalEntity result = null;
            if (adoxio_legalentity != null)
            {
                result = new ViewModels.AdoxioLegalEntity();
                if (adoxio_legalentity.AdoxioLegalentityid != null)
                {
                    result.id = adoxio_legalentity.AdoxioLegalentityid.ToString();
                }

                if (adoxio_legalentity._adoxioAccountValue != null)
                {
                    result.accountId = adoxio_legalentity._adoxioAccountValue;
                }

                result.commonnonvotingshares = adoxio_legalentity.AdoxioCommonnonvotingshares;
                result.commonvotingshares = adoxio_legalentity.AdoxioCommonvotingshares;
                result.dateofbirth = adoxio_legalentity.AdoxioDateofbirth;
                result.firstname = adoxio_legalentity.AdoxioFirstname;
                result.interestpercentage = (decimal?)adoxio_legalentity.AdoxioInterestpercentage;
                // convert from int to bool.
                result.isindividual = (adoxio_legalentity.AdoxioIsindividual != null && adoxio_legalentity.AdoxioIsindividual != 0);
                result.lastname = adoxio_legalentity.AdoxioLastname;
                if (adoxio_legalentity.AdoxioLegalentitytype != null)
                {
                    result.legalentitytype = (Adoxio_applicanttypecodes)adoxio_legalentity.AdoxioLegalentitytype;
                }

                result.middlename = adoxio_legalentity.AdoxioMiddlename;
                result.name = adoxio_legalentity.AdoxioName;
                result.email = adoxio_legalentity.AdoxioEmail;
                result.isPartner =  (adoxio_legalentity.AdoxioIspartner == true);
                result.isShareholder =  (adoxio_legalentity.AdoxioIsshareholder == true);
                // result.isTrustee =  adoxio_legalentity.AdoxioIstrustee;
                // result.isOwner =  adoxio_legalentity.AdoxioIsowner;
                result.isDirector = (adoxio_legalentity.AdoxioIsdirector == true);
                result.isOfficer = (adoxio_legalentity.AdoxioIsofficer == true);
                result.isSeniorManagement = (adoxio_legalentity.AdoxioIsseniormanagement == true);

                result.preferrednonvotingshares = adoxio_legalentity.AdoxioPreferrednonvotingshares;
                result.preferredvotingshares = adoxio_legalentity.AdoxioPreferredvotingshares;
                // convert from int to bool.
                result.sameasapplyingperson = (adoxio_legalentity.AdoxioSameasapplyingperson != null && adoxio_legalentity.AdoxioSameasapplyingperson != 0);
                result.dateofappointment = adoxio_legalentity.AdoxioDateofappointment;

                // populate the account.
                if (adoxio_legalentity.AdoxioAccount != null)
                {
                    result.account = adoxio_legalentity.AdoxioAccount.ToViewModel();
                }

            }
            return result;
        }

        /// <summary>
        /// Convert a legal entity to a model
        /// </summary>
        /// <param name="from"></param>
        /// <returns></returns>
        public static Adoxio_legalentity ToModel(this ViewModels.AdoxioLegalEntity from)
        {
            Adoxio_legalentity result = null;
            if (from != null)
            {
                result = new Adoxio_legalentity();

                result.Adoxio_legalentityid = new Guid(from.id);
                result.Adoxio_commonnonvotingshares = from.commonnonvotingshares;
                result.Adoxio_commonvotingshares = from.commonvotingshares;
                result.Adoxio_dateofbirth = from.dateofbirth;
                result.Adoxio_firstname = from.firstname;
                result.Adoxio_interestpercentage = from.interestpercentage;
                result.Adoxio_isindividual = (from.isindividual != null && (bool)from.isindividual) ? 1 : 0;
                result.Adoxio_lastname = from.lastname;
                result.Adoxio_legalentitytype = (int?)from.legalentitytype;
                result.Adoxio_middlename = from.middlename;
                result.Adoxio_name = from.name;

                result.Adoxio_ispartner = (from.isPartner == true);
                result.Adoxio_isshareholder =  (from.isShareholder == true);
                //result.AdoxioIstrustee = from.isTrustee;
                //result.AdoxioIsowner = from.isOwner;
                result.Adoxio_isdirector = (from.isDirector == true);
                result.Adoxio_isofficer = (from.isOfficer == true);
                result.Adoxio_isseniormanagement = (from.isSeniorManagement == true);

                result.Adoxio_preferrednonvotingshares = from.preferrednonvotingshares;
                result.Adoxio_preferredvotingshares = from.preferredvotingshares;
                result.Adoxio_sameasapplyingperson = (from.sameasapplyingperson != null && (bool)from.sameasapplyingperson) ? 1 : 0;
                result.Adoxio_dateofappointment = from.dateofappointment;
            }
            return result;
        }

    }

}
