using AutoMapper;
using ProductManagement.BL.DTOs;
using ProductManagement.BL.InterfacesBL;
using ProductManagement.BL.Utilities;
using ProductManagement.BL.Validators;
using ProductManagement.DAL.EntitiesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.EntitiesBL
{
    public class SupplierBL : IBaseBL<CreateSupplierDto, UpdateSupplierDto>
    {
        // Fields for mapping and DAO.
        private readonly SupplierDAO _supplierDAO;

        private readonly IMapper _mapper;

        // Initialize constructor
        public SupplierBL()
        {
            _supplierDAO = new SupplierDAO();
            _mapper = AutoMapperConfig.Inicialize();
        }

        public OperationResultDto Create(CreateSupplierDto createDto)
        {
            throw new NotImplementedException();
        }

        public OperationResultDto Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public OperationResultDto FindById(int entityId)
        {
            throw new NotImplementedException();
        }

        public OperationResultDto Update(UpdateSupplierDto updateDto)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Business Intelligence validation before creating a Supplier.
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        public string ValidateBeforeCreate(CreateSupplierDto createDto)
        {
            // Definition of variables.
            var errorMessage = string.Empty;

            // Implementation of validations.
            var validator = new CreateSupplierValidator();

            var validationResult = validator.Validate(createDto);

            // Validation DTO.
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ToString(" \n ");
                return errorMessage;
            }

            return errorMessage;
        }

        public string ValidateBeforeDelete(int entityId)
        {
            throw new NotImplementedException();
        }

        public string ValidateBeforeUpdate(UpdateSupplierDto updateDto)
        {
            throw new NotImplementedException();
        }

        public OperationResultDto GetListSupplier()
        {
            var result = new OperationResultDto();

            var supplierModel = _supplierDAO.GetAll();

            var supplierDto = _mapper.Map<List<ReadSupplierDto>>(supplierModel);

            if (supplierDto.Count == 0)
            {
                result.Message = "No se encontraron registros.";
                result.Success = false;
                result.Result = null;

                return result;
            }

            result.Message = "Registros encontrados.";
            result.Success = true;
            result.Result = supplierDto;

            return result;
        }
    }
}
