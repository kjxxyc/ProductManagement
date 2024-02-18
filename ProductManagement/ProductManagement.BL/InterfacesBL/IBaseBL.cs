using FluentValidation.TestHelper;
using ProductManagement.BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.InterfacesBL
{
    public interface IBaseBL<TEntityCreate, TEntityUpdate> where TEntityCreate : class where TEntityUpdate : class
    {
        /// <summary>
        /// Valid before create record.
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        string ValidateBeforeCreate(TEntityCreate createDto);

        /// <summary>
        /// Valid before update record.
        /// </summary>
        /// <param name="updateDto"></param>
        /// <returns></returns>
        string ValidateBeforeUpdate(TEntityUpdate updateDto);

        /// <summary>
        /// Valid before delete record.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        string ValidateBeforeDelete(int entityId);

        /// <summary>
        /// Create a record
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        OperationResultDto Create(TEntityCreate createDto);

        /// <summary>
        /// Update a record.
        /// </summary>
        /// <param name="updateDto"></param>
        /// <returns></returns>
        OperationResultDto Update(TEntityUpdate updateDto);

        /// <summary>
        /// Delete a record.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        OperationResultDto Delete(int entityId);

        // TODO: falta el obtener registros?

        /// <summary>
        /// Find a record by Id.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        OperationResultDto FindById(int entityId);
    }
}
