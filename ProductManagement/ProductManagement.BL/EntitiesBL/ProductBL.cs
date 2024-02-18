using AutoMapper;
using FluentValidation;
using ProductManagement.BL.DTOs;
using ProductManagement.BL.InterfacesBL;
using ProductManagement.BL.Utilities;
using ProductManagement.BL.Validators;
using ProductManagement.DAL.EntitiesDAO;
using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.EntitiesBL
{
    public class ProductBL : IBaseBL<CreateProductDto, UpdateProductDto>
    {
        // Fields for mapping and DAO.
        private readonly ProductDAO _productDAO;

        private readonly IMapper _mapper;

        // Initialize constructor
        public ProductBL()
        {
            _productDAO = new ProductDAO();
            _mapper = AutoMapperConfig.Inicialize();
        }

        /// <summary>
        /// Create Product using validations.
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public OperationResultDto Create(CreateProductDto createDto)
        {
            // Definition of variables.
            var result = new OperationResultDto();
            var affectedRows = 0;
            var errorMessage = ValidateBeforeCreate(createDto);

            // Validate DTO
            if (string.IsNullOrEmpty(errorMessage))
            {
                // Map DTO to model
                var productModel = _mapper.Map<Product>(createDto);
                affectedRows = _productDAO.Create(productModel);
                affectedRows = _productDAO.Create(productModel);
                var readProduct = _mapper.Map<ReadProductDto>(productModel);

                result.Message = affectedRows > 0 ? "Creado con Exito." : "No se afectaron registros.";
                result.Success = affectedRows > 0;
                result.Result = readProduct;
            }
            else
            {
                result.Message = errorMessage;
                result.Success = false;
            }

            return result;
        }

        public OperationResultDto Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public OperationResultDto FindById(int entityId)
        {
            // Definition of variables.
            var result = new OperationResultDto();

            // Find user by Id.
            var userModel = _productDAO.FindById(entityId);
            var productDto = _mapper.Map<ReadProductDto>(userModel);

            // Validate if the record exists
            if (userModel == null)
            {
                result.Message = "No se encontraron registros.";
                result.Success = false;
                result.Result = null;
            }
            else
            {
                result.Message = "Usuario encontrado.";
                result.Success = true;
                result.Result = productDto;
            }

            return result;
        }

        public OperationResultDto Update(UpdateProductDto updateDto)
        {
            // Definition of variables.
            var result = new OperationResultDto();
            var affectedRows = 0;
            var errorMessage = ValidateBeforeUpdate(updateDto);

            // Validate DTO
            if (string.IsNullOrEmpty(errorMessage))
            {
                // Map DTO to model

                var productModel = _productDAO.FindById(updateDto.Id);
                _mapper.Map(updateDto, productModel);
                affectedRows = _productDAO.Update(productModel);

                var productDto = _mapper.Map<ReadProductDto>(productModel);

                result.Message = affectedRows > 0 ? "Actualizado con Exito." : "No se afectaron registros.";
                result.Success = affectedRows > 0;
                result.Result = productDto;
            }
            else
            {
                result.Message = errorMessage;
                result.Success = false;
            }

            return result;
        }


        /// <summary>
        /// Business Intelligence validation before creating a Product.
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string ValidateBeforeCreate(CreateProductDto createDto)
        {
            // Definition of variables.
            var errorMessage = string.Empty;

            // Implementation of validations.
            var validator = new CreateProductValidator();

            var validationResult = validator.Validate(createDto);

            // Validation DTO.
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ToString(" \n ");
                return errorMessage;
            }
            // Valid unique code.
            if (_productDAO.CheckWithCondition(x => x.CodeProduct.ToLower() == createDto.CodeProduct.ToLower()))
            {
                errorMessage = $"El Código del Producto: {createDto.CodeProduct} ya existe.";
                return errorMessage;
            }

            return errorMessage;
        }

        public string ValidateBeforeDelete(int entityId)
        {
            throw new NotImplementedException();
        }

        public string ValidateBeforeUpdate(UpdateProductDto updateDto)
        {
            // Definition of variables.
            var errorMessage = string.Empty;

            // Implementation of validations
            var validator = new UpdateProductValidator();

            var validationResult = validator.Validate(updateDto);

            // Validation DTO
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ToString("\n");
                return errorMessage;
            }

            return errorMessage;
        }

        public OperationResultDto GetListProductsWithFilter(string filterName, string filterStatus)
        {
            var result = new OperationResultDto();

            var productModel = _productDAO.GetListWithFilter(x =>
                                (string.IsNullOrEmpty(filterName) || x.ProductName.Contains(filterName)) &&
                                (string.IsNullOrEmpty(filterStatus) || x.Status == filterStatus));

            var productDto = _mapper.Map<List<ReadProductDto>>(productModel);

            if (productDto.Count == 0)
            {
                result.Message = "No se encontraron registros.";
                result.Success = false;
                result.Result = null;

                return result;
            }

            result.Message = "Registros encontrados.";
            result.Success = true;
            result.Result = productDto;

            return result;
        }
    }
}
