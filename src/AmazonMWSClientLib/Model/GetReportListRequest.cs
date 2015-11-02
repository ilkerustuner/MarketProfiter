/******************************************************************************* 
 *  Copyright 2009 Amazon Services.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  Marketplace Web Service CSharp Library
 *  API Version: 2009-01-01
 *  Generated: Mon Mar 16 17:31:42 PDT 2009 
 * 
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using MarketplaceWebService.Attributes;


namespace MarketplaceWebService.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    [MarketplaceWebServiceAttribute(RequestType = RequestType.DEFAULT, ResponseType = ResponseType.DEFAULT)]
    public class GetReportListRequest
    {
    
        
        private String merchantField;
        private String mwsAuthTokenField;

        private Decimal? maxCountField;

        private  TypeList reportTypeListField;
        private Boolean? acknowledgedField;

        private DateTime? availableFromDateField;

        private DateTime? availableToDateField;

        private  IdList reportRequestIdListField;
        

        /// <summary>
        /// Gets and sets the Merchant property.
        /// </summary>
        [XmlElement(ElementName = "Merchant")]
        public String Merchant
        {
            get { return this.merchantField ; }
            set { this.merchantField= value; }
        }



        /// <summary>
        /// Sets the Merchant property
        /// </summary>
        /// <param name="merchant">Merchant property</param>
        /// <returns>this instance</returns>
        public GetReportListRequest WithMerchant(String merchant)
        {
            this.merchantField = merchant;
            return this;
        }



        /// <summary>
        /// Checks if Merchant property is set
        /// </summary>
        /// <returns>true if Merchant property is set</returns>
        public Boolean IsSetMerchant()
        {
            return  this.merchantField != null;

        }


        /// <summary>
        /// Gets and sets the MWSAuthToken property.
        /// </summary>
        [XmlElement(ElementName = "MWSAuthToken")]
        public String MWSAuthToken
        {
            get { return this.mwsAuthTokenField; }
            set { this.mwsAuthTokenField = value; }
        }



        /// <summary>
        /// Sets the MWSAuthToken property
        /// </summary>
        /// <param name="mwsAuthToken">MWSAuthToken property</param>
        /// <returns>this instance</returns>
        public GetReportListRequest WithMWSAuthToken(String mwsAuthToken)
        {
            this.mwsAuthTokenField = mwsAuthToken;
            return this;
        }



        /// <summary>
        /// Checks if MWSAuthToken property is set
        /// </summary>
        /// <returns>true if MWSAuthToken property is set</returns>
        public Boolean IsSetMWSAuthToken()
        {
            return this.mwsAuthTokenField != null;
        }


        /// <summary>
        /// Gets and sets the MaxCount property.
        /// </summary>
        [XmlElement(ElementName = "MaxCount")]
        public Decimal MaxCount
        {
            get { return this.maxCountField.GetValueOrDefault() ; }
            set { this.maxCountField= value; }
        }



        /// <summary>
        /// Sets the MaxCount property
        /// </summary>
        /// <param name="maxCount">MaxCount property</param>
        /// <returns>this instance</returns>
        public GetReportListRequest WithMaxCount(Decimal maxCount)
        {
            this.maxCountField = maxCount;
            return this;
        }



        /// <summary>
        /// Checks if MaxCount property is set
        /// </summary>
        /// <returns>true if MaxCount property is set</returns>
        public Boolean IsSetMaxCount()
        {
            return  this.maxCountField.HasValue;

        }


        /// <summary>
        /// Gets and sets the ReportTypeList property.
        /// </summary>
        [XmlElement(ElementName = "ReportTypeList")]
        public TypeList ReportTypeList
        {
            get { return this.reportTypeListField ; }
            set { this.reportTypeListField = value; }
        }



        /// <summary>
        /// Sets the ReportTypeList property
        /// </summary>
        /// <param name="reportTypeList">ReportTypeList property</param>
        /// <returns>this instance</returns>
        public GetReportListRequest WithReportTypeList(TypeList reportTypeList)
        {
            this.reportTypeListField = reportTypeList;
            return this;
        }



        /// <summary>
        /// Checks if ReportTypeList property is set
        /// </summary>
        /// <returns>true if ReportTypeList property is set</returns>
        public Boolean IsSetReportTypeList()
        {
            return this.reportTypeListField != null;
        }




        /// <summary>
        /// Gets and sets the Acknowledged property.
        /// </summary>
        [XmlElement(ElementName = "Acknowledged")]
        public Boolean Acknowledged
        {
            get { return this.acknowledgedField.GetValueOrDefault() ; }
            set { this.acknowledgedField= value; }
        }



        /// <summary>
        /// Sets the Acknowledged property
        /// </summary>
        /// <param name="acknowledged">Acknowledged property</param>
        /// <returns>this instance</returns>
        public GetReportListRequest WithAcknowledged(Boolean acknowledged)
        {
            this.acknowledgedField = acknowledged;
            return this;
        }



        /// <summary>
        /// Checks if Acknowledged property is set
        /// </summary>
        /// <returns>true if Acknowledged property is set</returns>
        public Boolean IsSetAcknowledged()
        {
            return  this.acknowledgedField.HasValue;

        }


        /// <summary>
        /// Gets and sets the AvailableFromDate property.
        /// </summary>
        [XmlElement(ElementName = "AvailableFromDate")]
        public DateTime AvailableFromDate
        {
            get { return this.availableFromDateField.GetValueOrDefault() ; }
            set { this.availableFromDateField= value; }
        }



        /// <summary>
        /// Sets the AvailableFromDate property
        /// </summary>
        /// <param name="availableFromDate">AvailableFromDate property</param>
        /// <returns>this instance</returns>
        public GetReportListRequest WithAvailableFromDate(DateTime availableFromDate)
        {
            this.availableFromDateField = availableFromDate;
            return this;
        }



        /// <summary>
        /// Checks if AvailableFromDate property is set
        /// </summary>
        /// <returns>true if AvailableFromDate property is set</returns>
        public Boolean IsSetAvailableFromDate()
        {
            return  this.availableFromDateField.HasValue;

        }


        /// <summary>
        /// Gets and sets the AvailableToDate property.
        /// </summary>
        [XmlElement(ElementName = "AvailableToDate")]
        public DateTime AvailableToDate
        {
            get { return this.availableToDateField.GetValueOrDefault() ; }
            set { this.availableToDateField= value; }
        }



        /// <summary>
        /// Sets the AvailableToDate property
        /// </summary>
        /// <param name="availableToDate">AvailableToDate property</param>
        /// <returns>this instance</returns>
        public GetReportListRequest WithAvailableToDate(DateTime availableToDate)
        {
            this.availableToDateField = availableToDate;
            return this;
        }



        /// <summary>
        /// Checks if AvailableToDate property is set
        /// </summary>
        /// <returns>true if AvailableToDate property is set</returns>
        public Boolean IsSetAvailableToDate()
        {
            return  this.availableToDateField.HasValue;

        }


        /// <summary>
        /// Gets and sets the ReportRequestIdList property.
        /// </summary>
        [XmlElement(ElementName = "ReportRequestIdList")]
        public IdList ReportRequestIdList
        {
            get { return this.reportRequestIdListField ; }
            set { this.reportRequestIdListField = value; }
        }



        /// <summary>
        /// Sets the ReportRequestIdList property
        /// </summary>
        /// <param name="reportRequestIdList">ReportRequestIdList property</param>
        /// <returns>this instance</returns>
        public GetReportListRequest WithReportRequestIdList(IdList reportRequestIdList)
        {
            this.reportRequestIdListField = reportRequestIdList;
            return this;
        }



        /// <summary>
        /// Checks if ReportRequestIdList property is set
        /// </summary>
        /// <returns>true if ReportRequestIdList property is set</returns>
        public Boolean IsSetReportRequestIdList()
        {
            return this.reportRequestIdListField != null;
        }







    }

}
