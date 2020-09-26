using PlaneTreeNetwork.Hotel.Business.Abstract;
using PlaneTreeNetwork.Hotel.Business.DependencyResolvers.Ninject;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RoomService
/// </summary>
public class RoomService:IRoomService
{
    public RoomService()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    IRoomService _roomService = InstanceFactory.GetInstance<IRoomService>();
    public Room Add(Room room)
    {
       return _roomService.Add(room);
    }

    public List<Room> GetAll()
    {
        return _roomService.GetAll();

    }

    public Room GetById(int id)
    {
        return _roomService.GetById(id);
    }

    public void TransactionalOperation(Room room1, Room room2)
    {
        _roomService.TransactionalOperation(room1, room2);
    }

    public Room Update(Room room)
    {
        return _roomService.Update(room);
    }
}