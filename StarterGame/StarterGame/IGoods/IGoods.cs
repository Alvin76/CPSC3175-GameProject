using System;
using System.Collections.Generic;
using System.Text;

namespace StarterGame.IGoods
{
    // interface version of the Goods
    // enum ItemType { KEYITEM, WEAPON, HEAD, SHIRT, PANTS, SHOES, GLOVES, CONSUMABLE, OTHER }

    public interface IGoods
    {
        // basic accessor fuctions
        String ItemName {get; set; }
        float Volumn { get; set; }
        float Weight { get; set; }
        int Count { get; set; }
        float Worth { get; set; }
        bool Destroyable { get; set; }
        bool Useable { get; set; }
        //ItemType Type { get; set; }
    }
}