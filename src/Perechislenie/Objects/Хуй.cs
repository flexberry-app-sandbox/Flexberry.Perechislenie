﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Perechislenie
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Хуй.
    /// </summary>
    // *** Start programmer edit section *** (Хуй CustomAttributes)

    // *** End programmer edit section *** (Хуй CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ХуйE", new string[] {
            "перечисление as \'Перечисление\'"})]
    [View("ХуйL", new string[] {
            "перечисление as \'Перечисление\'"})]
    public class Хуй : ICSSoft.STORMNET.DataObject
    {
        
        private IIS.Perechislenie.хуй1 fперечисление;
        
        // *** Start programmer edit section *** (Хуй CustomMembers)

        // *** End programmer edit section *** (Хуй CustomMembers)

        
        /// <summary>
        /// перечисление.
        /// </summary>
        // *** Start programmer edit section *** (Хуй.перечисление CustomAttributes)

        // *** End programmer edit section *** (Хуй.перечисление CustomAttributes)
        public virtual IIS.Perechislenie.хуй1 перечисление
        {
            get
            {
                // *** Start programmer edit section *** (Хуй.перечисление Get start)

                // *** End programmer edit section *** (Хуй.перечисление Get start)
                IIS.Perechislenie.хуй1 result = this.fперечисление;
                // *** Start programmer edit section *** (Хуй.перечисление Get end)

                // *** End programmer edit section *** (Хуй.перечисление Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Хуй.перечисление Set start)

                // *** End programmer edit section *** (Хуй.перечисление Set start)
                this.fперечисление = value;
                // *** Start programmer edit section *** (Хуй.перечисление Set end)

                // *** End programmer edit section *** (Хуй.перечисление Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ХуйE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ХуйE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ХуйE", typeof(IIS.Perechislenie.Хуй));
                }
            }
            
            /// <summary>
            /// "ХуйL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ХуйL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ХуйL", typeof(IIS.Perechislenie.Хуй));
                }
            }
        }
    }
}
