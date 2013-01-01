﻿namespace Thunder.ComponentModel.DataAnnotations
{
    /// <summary>
    /// Document type
    /// </summary>
    public enum DocumentType : short
    {
        /// <summary>
        /// Cnpj
        /// </summary>
        Cnpj,
        /// <summary>
        /// Cpf
        /// </summary>
        Cpf
    }

    /// <summary>
    /// Required if operator
    /// </summary>
    public enum RequiredIfOperator
    {
        /// <summary>
        /// Equal to
        /// </summary>
        EqualTo,
        /// <summary>
        /// Not equal to
        /// </summary>
        NotEqualTo
    }
}
