//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//

// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>

namespace Earn.Dashboard.DAL.db.Commerce
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReferralType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReferralType()
        {
            this.ReferralEventRewards = new HashSet<ReferralEventReward>();
        }
    
        public System.Guid Id { get; set; }
        public int Sequence { get; set; }
        public string Code { get; set; }
        public System.Guid ReferrerId { get; set; }
        public int ReferrerTypeId { get; set; }
        public int ReferralVectorId { get; set; }
        public int RewardRecipientId { get; set; }
        public System.DateTime CreatedDateUtc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReferralEventReward> ReferralEventRewards { get; set; }
        public virtual ReferralVector ReferralVector { get; set; }
        public virtual ReferrerType ReferrerType { get; set; }
        public virtual RewardRecipient RewardRecipient { get; set; }
    }
}