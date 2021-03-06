﻿/***********************
 @ author:zlong
 @ Date:2015-01-08
 @ Desc:场地出租情况记录实体
 * ********************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DriveMgr.Model
{
    public class SiteRentalModel
    {
        private int _id;
        private int? _vehicleid;
        private string _rentobject;
        private int? _priceconfigid;
        private decimal? _longer;
        private decimal? _totalprice;
        private string _remark;
        private string _createperson;
        private DateTime? _createdate;
        private DateTime? _rentDate;
        private string _updateperson;
        private DateTime? _updatedate;
        private bool _deletemark = false;
        /// <summary>
        /// 编号
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 车辆外键
        /// </summary>
        public int? VehicleId
        {
            set { _vehicleid = value; }
            get { return _vehicleid; }
        }
        /// <summary>
        /// 出租时间
        /// </summary>
        public DateTime? RentDate
        {
            set { _rentDate = value; }
            get { return _rentDate; }
        }
        /// <summary>
        /// 出租对象
        /// </summary>
        public string RentObject
        {
            set { _rentobject = value; }
            get { return _rentobject; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? PriceConfigID
        {
            set { _priceconfigid = value; }
            get { return _priceconfigid; }
        }
        /// <summary>
        /// 时长
        /// </summary>
        public decimal? Longer
        {
            set { _longer = value; }
            get { return _longer; }
        }
        /// <summary>
        /// 总价
        /// </summary>
        public decimal? TotalPrice
        {
            set { _totalprice = value; }
            get { return _totalprice; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatePerson
        {
            set { _createperson = value; }
            get { return _createperson; }
        }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 更新日期
        /// </summary>
        public string UpdatePerson
        {
            set { _updateperson = value; }
            get { return _updateperson; }
        }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime? UpdateDate
        {
            set { _updatedate = value; }
            get { return _updatedate; }
        }
        /// <summary>
        /// 删除标志
        /// </summary>
        public bool DeleteMark
        {
            set { _deletemark = value; }
            get { return _deletemark; }
        }
    }
}
