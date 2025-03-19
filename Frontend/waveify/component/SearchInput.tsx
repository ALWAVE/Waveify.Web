"use client";

import { BiSearch } from "react-icons/bi";

const SearchInput = () => {
    return (
        <form className="relative w-full">
            <input
                type="text"
                placeholder="Search beat, producer, playlist or #tag"
                // minLength="3"
                className="h-12 w-full rounded-lg bg-neutral-800 py-2 pl-10 pr-4  placeholder-gray-400 outline-none focus:ring-2 focus:ring-pink-800 transition "
            />
            <BiSearch className="absolute left-3 top-1/2 transform -translate-y-1/2 text-gray-500" size={20} />
        </form>
    );
};

export default SearchInput;
