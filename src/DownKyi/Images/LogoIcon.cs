﻿namespace DownKyi.Images
{
    class LogoIcon
    {
        private static LogoIcon instance;
        public static LogoIcon Instance()
        {
            if (instance == null)
            {
                instance = new LogoIcon();
            }
            return instance;
        }

        private LogoIcon()
        {
            TextLogo = new VectorImage
            {
                Height = 100,
                Width = 336,
                Data = @"M602.247902 495.326917q0-146.045116 60.22479-219.820484a198.13956 198.13956 0 0 1 308.953174 0q61.73041
                         74.076492 62.031534 213.798005 0 150.561976-60.22479 225.54184a198.13956 198.13956 0 0 1-309.254298 0Q602.247902 640.468662
                         602.247902 495.326917z m80.098971 0A273.721671 273.721671 0 0 0 722.697482 657.331603a120.44958 120.44958 0 0 0 98.467532
                         53.298939 115.029349 115.029349 0 0 0 94.251797-53.901187 273.420548 273.420548 0 0 0 39.447238-161.703562 271.011556
                         271.011556 0 0 0-39.748362-162.004685 120.44958 120.44958 0 0 0-98.467532-53.29894A114.125977 114.125977 0 0 0 722.697482
                         333.322232a271.011556 271.011556 0 0 0-39.748361 161.703561zM1212.023903 776.275564L1070.194522 214.077147h80.701219l73.474244
                         324.611619 27.101155 120.449581 24.391041-116.836093L1349.035301 214.077147h80.701218l68.656261 326.117239 23.186545 107.501251
                         26.498907-108.705747L1626.069336 214.077147h76.184359l-143.335001 562.198417h-81.303466l-73.474244-336.656578-17.46519-95.757416L1294.832989
                         776.275564zM1768.500964 776.275564V214.077147h70.463005v79.496723a180.674371 180.674371 0 0 1 62.031534-69.258509 154.476587
                         154.476587 0 0 1 84.314706-22.88542 161.703562 161.703562 0 0 1 68.355137 14.45395 140.624885 140.624885 0 0 1 50.588824
                         38.242742 153.874339 153.874339 0 0 1 30.112395 60.22479 509.802849 509.802849 0 0 1 9.635966
                         115.330473v346.593668h-79.195599V433.897631a279.141903 279.141903 0 0 0-10.539338-90.337185 87.62707 87.62707 0 0
                         0-85.218078-60.22479 109.00687 109.00687 0 0 0-90.337186 41.856229q-33.424759 42.157353-33.424758 143.636125v307.447554zM2270.775715
                         776.275564V0.279142h84.314706v384.836409L2670.969446 0.279142h114.427101l-267.096945 314.674529 278.539655
                         461.321893h-111.114738l-225.842963-391.461137-104.791135 123.46082v268.903689zM2853.149436 993.98818l-8.732595-90.337185a146.34624
                         146.34624 0 0 0 44.566345 8.431471 78.292227 78.292227 0 0 0 41.253981-9.937091 76.786608 76.786608 0 0 0 26.498908-30.112395c2.710116-5.119107
                         12.94833-36.134874 30.112395-93.348425L2812.196579 214.077147h84.314706l96.359664 325.514991c12.044958 40.350609
                         22.88542 83.712458 33.123635 130.085547 9.033719-43.662973 19.573057-86.422574 31.919139-127.977679l98.467532-327.622859h78.292227l-174.953016
                         572.135507a1012.679847 1012.679847 0 0 1-54.202311 147.550736 141.227133 141.227133 0 0 1-45.168592 53.600063 103.285515 103.285515 0 0
                         1-56.912427 16.561818 132.494538 132.494538 0 0 1-50.2877-9.937091zM3300.318503 109.88826V0.279142h77.68998v109.609118z
                         m0 666.387304V214.077147h77.68998v562.198417zM0 776.275564V0.279142h219.51936a417.357796 417.357796 0 0 1 124.063068
                         14.152826 210.786766 210.786766 0 0 1 96.359664 67.752889 358.337502 358.337502 0 0 1 63.537154 124.364191 616.400728 616.400728 0 0 1
                         22.584296 177.362008 579.663606 579.663606 0 0 1-38.543865 223.735095 273.420548 273.420548 0 0 1-99.370904 130.386671 294.1981
                         294.1981 0 0 1-158.391198 38.242742zM463.730885 391.740278q10.840462-7.528099
                         0-16.260693l-51.79332-30.112395q-136.40915-82.507963-276.431787-150.561976l-13.249454-6.624727a22.283172 22.283172
                         0 0 0-16.561817 0v405.613962a18.669685 18.669685 0 0 0 14.755073-4.817983q148.152984-76.786608 296.607092-164.413677c15.357322-10.238214
                         31.015767-21.379801 46.674213-32.822511z",
                Fill = "#FF000000"
            };
        }

        public VectorImage TextLogo { get; private set; }
    }
}
