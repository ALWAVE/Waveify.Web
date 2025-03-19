import Link from "next/link";
import { twMerge } from "tailwind-merge";

interface SidebarItemProps {
  icon: React.ReactNode;
  label: string;
  active?: boolean;
  href: string;
}

const SidebarItem: React.FC<SidebarItemProps> = ({
  icon,
  label,
  active,
  href,
}) => {
  return (
    <Link
      href={href}
      className={twMerge(
        `
        relative group
        flex flex-row
        h-auto justify-center
        w-auto gap-x-4
        text-md font-medium
        cursor-pointer hover:text-white
        transition text-neutral-400
        py-1 bg-neutral-800 rounded-full
        border-transparent border-1 hover:border-pink-200/20 py-2 px-2
        hover:scale-110
        `,
        active && "text-white"
      )}
    >
      {icon}

      {/* Tooltip снизу */}
      <span
      className="mt-3 absolute top-full left-1/2 text-sm -translate-x-1/2 mb-4 w-max px-2 py-1 text-white bg-neutral-900 rounded-md opacity-0 transition-all duration-290 group-hover:opacity-100 group-hover:scale-100  pointer-events-none"
      >
        {label}
      </span>
   
    </Link>
  );
};

export default SidebarItem;
