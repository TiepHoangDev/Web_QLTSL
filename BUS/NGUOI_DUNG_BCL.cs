
using DAL;
using DTO;
using System;
using System.Collections.Generic;
namespace BUS
{
    public class NGUOI_DUNG_BCL
    {
        
public List<NGUOI_DUNG_Object> GetAll()
{
    return new NGUOI_DUNG_Dao().GetAll();
}

        
public NGUOI_DUNG_Object GetByID_NGUOIDUNG(System.Int32 ID_NGUOIDUNG)
{
    return new NGUOI_DUNG_Dao().GetByID_NGUOIDUNG(ID_NGUOIDUNG);
}

        
public bool Insert(NGUOI_DUNG_Object ob)
{
    return new NGUOI_DUNG_Dao().Insert(ob);
}

        
public bool Delete(System.Int32 ID_NGUOIDUNG)
{
    return new NGUOI_DUNG_Dao().Delete(ID_NGUOIDUNG);
}

        
public bool Update(NGUOI_DUNG_Object ob)
{
    return new NGUOI_DUNG_Dao().Update(ob);
}

    }
}