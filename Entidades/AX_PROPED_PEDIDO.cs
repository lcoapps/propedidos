//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class AX_PROPED_PEDIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AX_PROPED_PEDIDO()
        {
            this.AX_PROPED_DETALLE_PEDIDO = new HashSet<AX_PROPED_DETALLE_PEDIDO>();
        }
    
        public int id_pedido { get; set; }
        public Nullable<int> id_cia { get; set; }
        public Nullable<int> liquida_imp { get; set; }
        public Nullable<int> consecu_auto_reg { get; set; }
        public Nullable<int> ind_contacto { get; set; }
        public string id_Co { get; set; }
        public string id_tipo_doc { get; set; }
        public string Pedido { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> id_clase_doc { get; set; }
        public Nullable<int> ind_estado { get; set; }
        public Nullable<int> ind_backorder { get; set; }
        public string Cliente { get; set; }
        public string razon_social { get; set; }
        public string id_suc_cliente_fact { get; set; }
        public string cliente_despachar { get; set; }
        public string id_suc_cliente_desp { get; set; }
        public string id_co_fact { get; set; }
        public Nullable<System.DateTime> fecha_entrega { get; set; }
        public Nullable<int> num_dias_entrega { get; set; }
        public string orden_compra { get; set; }
        public string id_moneda { get; set; }
        public string id_moneda_base { get; set; }
        public Nullable<int> tasa_conversion { get; set; }
        public string moneda_local { get; set; }
        public Nullable<int> tasa_local { get; set; }
        public string id_cond_pago { get; set; }
        public Nullable<int> id_estado_impresion { get; set; }
        public string notas { get; set; }
        public string id_punto_envio { get; set; }
        public string id_vendedor { get; set; }
        public string direccion_1 { get; set; }
        public string direccion_2 { get; set; }
        public string direccion_3 { get; set; }
        public Nullable<int> indicador_descuento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AX_PROPED_DETALLE_PEDIDO> AX_PROPED_DETALLE_PEDIDO { get; set; }
    }
}
