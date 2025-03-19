"use client"
// import { usePathname } from "next/navigation";
// import { useMemo } from "react";
// import { BiSearch } from "react-icons/bi";
// import { CiStar } from "react-icons/ci";
// import { GoHome } from "react-icons/go";
// import { BiLibrary } from "react-icons/bi";
import Box from "./Box";
// import SidebarItem from "./SidebarItem";
import { twMerge } from "tailwind-merge";
// import Header from "./Header";

interface SidebarProps {
  children: React.ReactNode;
}

const Sidebar: React.FC<SidebarProps> = () => {
  // const pathname = usePathname();

  // const route = useMemo(() => [
  //   {   
  //     icon: <GoHome size={26} />,
  //     label: "Home",
  //     active: pathname === "/",
  //     href: "/",
  //   },
  //   {
  //     icon: <BiSearch size={26} />,
  //     label: "Search",
  //     active: pathname === "/search",
  //     href: "/search",
  //   },
  //   {
  //       icon: <CiStar size={26} />,
  //       label: "For you",
  //       active: pathname === "/for_you",
  //       href: "/for_you",
  //   },
  //   {
  //       icon: <BiLibrary size={26} />,
  //       label: "Your collection",
  //       active: pathname === "/collection",
  //       href: "/collection",
  //   },
  // ], [pathname]);

  return (
   <div>
    {/* <div className={twMerge(`flex h-full`, "h-[calc(100%-80px)]")}> */}
    <div className={twMerge(`flex h-full`)}>

      
      <div className="hidden md:flex flex-col gap-y-2 bg-black h-full w-[300px] pr-2 pl-2">
        {/* <Box>
          <div className="flex flex-col gap-y-3 px-5 py-4">
            {route.map((item) => (
              <SidebarItem 
                key={item.label}
                {...item}
              />
            ))}
          </div>
        </Box> */}
        <Box className="overflow-y-auto h-full">
          Song Library and Instrument
        </Box>
      </div>
      
      </div>
    </div>
  );
};

export default Sidebar;
