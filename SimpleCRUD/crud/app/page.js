import reactDom from "react-dom";;
import Image from "next/image";

export default function Home() {
  return (
    <div class="flex ">      
      
      <form action="/">
        <label>Your task:</label>
          <input type="text"></input>
          <button className="bg-white w-7 h-7 py-7 px-4" type="submit">create</button>
      </form>
    </div>
    );
}
