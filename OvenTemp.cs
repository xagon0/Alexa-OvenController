public static int OvenTemp(int lookup)
	{
  
  //Return the most appropriate temperature value knowing temperatures
  //can only use the keys '2,3,4,5,7,0' and cannot use '1,6,8,9'.
  //Rounds up to the nearest '25' above the minimum amount.
  
		string[] array = { "200","202","203","204","205","207","220","222","223","224","225",
						  "227","230","232","233","234","235","237","240","242","243","244",
						  "245","247","250","252","253","254","255","257","270","272","273",
						  "274","275","277","300","302","303","304","305","307","320","322",
						  "323","324","325","327","330","332","333","334","335","337","340",
						  "342","343","344","345","347","350","352","353","354","355","357",
						  "370","372","373","374","375","377","400","402","403","404","405",
						  "407","420","422","423","424","425","427","430","432","433","434",
						  "435","437","440","442","443","444","445","447","450","452","453",
						  "454","455","457","470","472","473","474","475","477","500" };
		
    //does the value occur in the acceptable list.
		bool a = Array.Exists(array, element => element == lookup.ToString());
    
    //value above maximum
    if (lookup >= 501) {return 500;}
    
		//is an acceptable number
		if (a == true) {return lookup;}
    
    //rounds up to nearest value (below minimum, or not in list)
		else {return int.Parse(Math.Max(Math.Ceiling(lookup / 25.0) * 25.0, 225).ToString());	}
	}
