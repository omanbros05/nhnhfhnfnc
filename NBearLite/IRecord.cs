using System;
namespace NBearLite
{
    /// <summary>
    /// The interface of ReadOnly Record.
    /// </summary>
    public interface IReadOnlyRecord
    {
        /// <summary>
        /// Existses this instance.
        /// </summary>
        /// <returns></returns>
        bool Exists();
        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        void Refresh();
    }

    /// <summary>
    /// The interface of Record.
    /// </summary>
    public interface IRecord : IReadOnlyRecord
    {
        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="tran">The tran.</param>
        void Create(System.Data.Common.DbTransaction tran);
        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="tran">The tran.</param>
        /// <param name="specifiedFieldsToCreate">The specified fields to create.</param>
        void Create(System.Data.Common.DbTransaction tran, params string[] specifiedFieldsToCreate);
        /// <summary>
        /// Creates the specified fields to create.
        /// </summary>
        /// <param name="specifiedFieldsToCreate">The specified fields to create.</param>
        void Create(params string[] specifiedFieldsToCreate);
        /// <summary>
        /// Creates this instance.
        /// </summary>
        void Create();
        /// <summary>
        /// Deletes this instance.
        /// </summary>
        /// <param name="tran">The tran.</param>
        void Delete(System.Data.Common.DbTransaction tran);
        /// <summary>
        /// Deletes this instance.
        /// </summary>
        void Delete();
        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <param name="tran">The tran.</param>
        void Save(System.Data.Common.DbTransaction tran);
        /// <summary>
        /// Saves this instance.
        /// </summary>
        void Save();
        /// <summary>
        /// Updates this instance.
        /// </summary>
        /// <param name="tran">The tran.</param>
        /// <param name="specifiedFieldsToUpdate">The specified fields to update.</param>
        void Update(System.Data.Common.DbTransaction tran, params string[] specifiedFieldsToUpdate);
        /// <summary>
        /// Updates this instance.
        /// </summary>
        /// <param name="tran">The tran.</param>
        void Update(System.Data.Common.DbTransaction tran);
        /// <summary>
        /// Updates this instance.
        /// </summary>
        void Update();
        /// <summary>
        /// Updates the specified fields to update.
        /// </summary>
        /// <param name="specifiedFieldsToUpdate">The specified fields to update.</param>
        void Update(params string[] specifiedFieldsToUpdate);
    }
}
