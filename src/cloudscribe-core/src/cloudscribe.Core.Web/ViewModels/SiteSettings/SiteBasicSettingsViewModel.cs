﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:					Joe Audette
// Created:					2014-10-26
// Last Modified:			2015-09-11
// 

//using cloudscribe.Configuration.DataAnnotations;
//using cloudscribe.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Mvc.Rendering;

namespace cloudscribe.Core.Web.ViewModels.SiteSettings
{
    public class SiteBasicSettingsViewModel
    {
        public SiteBasicSettingsViewModel()
        {
            
        }

        private int siteID = -1;

        [Display(Name = "SiteId")]
        public int SiteId
        {
            get { return siteID; }
            set { siteID = value; }
        }

        private Guid siteGuid = Guid.Empty;

        [Display(Name = "SiteGuid")]
        public Guid SiteGuid
        {
            get { return siteGuid; }
            set { siteGuid = value; }

        }

        private string siteName = string.Empty;

        //[Required(ErrorMessageResourceName = "SiteNameRequired", ErrorMessageResourceType = typeof(CommonResources))]
        //[StringLengthWithConfig(MinimumLength = 3, MaximumLength = 255, MinLengthKey = "SiteNameMinLength", MaxLengthKey = "SiteNameMaxLength", ErrorMessageResourceName = "SiteNameLengthErrorFormat", ErrorMessageResourceType = typeof(CommonResources))]
        //[Display(Name = "SiteName", ResourceType = typeof(CommonResources))]
        public string SiteName
        {
            get { return siteName; }
            set { siteName = value; }
        }

        private string siteFolderName = string.Empty;

        //[Display(Name = "SiteFolderName", ResourceType = typeof(CommonResources))]
        public string SiteFolderName
        {
            get { return siteFolderName; }
            set { siteFolderName = value; }
        }

        private string hostName = string.Empty;
        //[Display(Name = "PreferredHostName", ResourceType = typeof(CommonResources))]
        public string HostName
        {
            get { return hostName; }
            set { hostName = value; }
        }

        private string timeZoneId = "Eastern Standard Time";

        [Required]
        //[Display(Name = "TimeZone", ResourceType = typeof(CommonResources))]
        public string TimeZoneId
        {
            get { return timeZoneId; }
            set { timeZoneId = value; }
        }

        private ReadOnlyCollection<TimeZoneInfo> allTimeZones = null;

        public ReadOnlyCollection<TimeZoneInfo> AllTimeZones
        {
            get { return allTimeZones; }
            set { allTimeZones = value; }
        }
        
        private int returnPageNumber = 1;

        public int ReturnPageNumber
        {
            get { return returnPageNumber; }
            set { returnPageNumber = value; }
        }

        private bool showDelete = false;

        public bool ShowDelete
        {
            get { return showDelete; }
            set { showDelete = value; }
        }


        private string closedMessage = string.Empty;

        //[AllowHtml]
        //[Display(Name = "ClosedMessage", ResourceType = typeof(CommonResources))]
        public string ClosedMessage
        {
            get { return closedMessage; }
            set { closedMessage = value; }
        }

        private bool isClosed = false;

        //[Display(Name = "IsClosed", ResourceType = typeof(CommonResources))]
        public bool IsClosed
        {
            get { return isClosed; }
            set { isClosed = value; }
        }

        private bool requireCaptchaOnLogin = false;

        //[Display(Name = "RequireCaptchaOnLogin", ResourceType = typeof(CommonResources))]
        public bool RequireCaptchaOnLogin
        {
            get { return requireCaptchaOnLogin; }
            set { requireCaptchaOnLogin = value; }
        }

        private bool requireCaptchaOnRegistration = false;

        //[Display(Name = "RequireCaptchaOnRegistration", ResourceType = typeof(CommonResources))]
        public bool RequireCaptchaOnRegistration
        {
            get { return requireCaptchaOnRegistration; }
            set { requireCaptchaOnRegistration = value; }
        }

        private string recaptchaPublicKey = string.Empty;

        //[Display(Name = "RecaptchaPublicKey", ResourceType = typeof(CommonResources))]
        public string RecaptchaPublicKey
        {
            get { return recaptchaPublicKey; }
            set { recaptchaPublicKey = value; }
        }

        private string recaptchaPrivateKey = string.Empty;

        //[Display(Name = "RecaptchaPrivateKey", ResourceType = typeof(CommonResources))]
        public string RecaptchaPrivateKey
        {
            get { return recaptchaPrivateKey; }
            set { recaptchaPrivateKey = value; }
        }

        private string microsoftClientId = string.Empty;

        public string MicrosoftClientId
        {
            get { return microsoftClientId; }
            set { microsoftClientId = value; }
        }

        private string microsoftClientSecret = string.Empty;

        public string MicrosoftClientSecret
        {
            get { return microsoftClientSecret; }
            set { microsoftClientSecret = value; }
        }

        private string googleClientId = string.Empty;

        public string GoogleClientId
        {
            get { return googleClientId; }
            set { googleClientId = value; }
        }

        private string googleClientSecret = string.Empty;

        public string GoogleClientSecret
        {
            get { return googleClientSecret; }
            set { googleClientSecret = value; }
        }

        private string facebookAppId = string.Empty;

        public string FacebookAppId
        {
            get { return facebookAppId; }
            set { facebookAppId = value; }
        }

        private string facebookAppSecret = string.Empty;

        public string FacebookAppSecret
        {
            get { return facebookAppSecret; }
            set { facebookAppSecret = value; }
        }

        private string twitterConsumerKey = string.Empty;

        public string TwitterConsumerKey
        {
            get { return twitterConsumerKey; }
            set { twitterConsumerKey = value; }
        }

        private string twitterConsumerSecret = string.Empty;

        public string TwitterConsumerSecret
        {
            get { return twitterConsumerSecret; }
            set { twitterConsumerSecret = value; }
        }





    }
}
