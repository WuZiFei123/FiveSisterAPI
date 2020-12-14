using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBLL
{
   public interface IBLLClothesType
    {
        List<ClothesType> GetClothesTypes();
        List<ClothesType> GetClothesType(int pid);
        List<ClothesType> GetClothesTypesByMasterId(int Id);
        List<ClothesType> GetClothesTypesById(int Id);
    }
}
