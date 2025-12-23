import { BrowserRouter, Route, Routes } from "react-router-dom";
import { PersonPage } from "./pages/PersonPage";

export function AppRoutes() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" Component={PersonPage} />
      </Routes>
    </BrowserRouter>
  );
}