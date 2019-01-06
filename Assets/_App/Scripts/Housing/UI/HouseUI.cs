using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HouseUI : MonoBehaviour
{
    public TMP_Text address1Text;
    public TMP_Text address2Text;
    public TMP_Text priceText;
    public TMP_Text bedroomCountText;
    public TMP_Text bathroomCountText;
    public TMP_Text squareMeterText;
    public TMP_Text salsmanPhoneText;
    public TMP_Text salsmanEmailText;

    public void Set(House house)
    {
        address1Text.text = house.address1;
        address2Text.text = house.address2;
        priceText.text = house.price.ToString("G");
        bedroomCountText.text = house.bedroomCount.ToString();
        bathroomCountText.text = house.bathroomCount.ToString();
        squareMeterText.text = house.squareMeter.ToString("G");
        salsmanPhoneText.text = house.salesman?.phone ?? string.Empty;
        salsmanEmailText.text = house.salesman?.email ?? string.Empty;
    }
}
